using OoTMM_Item_Hints_Overhaul.Properties;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Reflection;

namespace OoTMM_Item_Hints_Overhaul
{
    public partial class Form1 : Form
    {
        static string strFirstLine = "Seed: "; //String to check for first line in Spoiler Log
        static string strLocationListStart = "Location List"; //String to find beginning of Location List in Spoiler Log
        static string strSelectLocation = "Select a Location..."; //Default String to display in Combobox for Location Selection.
        static string strSelectItem = "Select an Item...";  //Default String to display in Combobox for Item Selection.
        static int intHintListMax = 99;
        int intHintListLength; //Maximum amount of Item Hints in games for array initialization
        //string fileSaveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OoTMMHints\";
        string fileSavePath = string.Empty;// = fileSaveDirectory + "SaveData.txt";
        static int intDataLines = 50;
        string[] data = new string[intDataLines];
        bool boolFilePathValid = false;
        bool boolSelected = false;
        bool boolShouldSaveFileLines = false;
        string filePath = string.Empty;
        string[] fileLines;
        string[] strHintItemList = new string[intHintListMax];
        string[] strHintLocationList = new string[intHintListMax];
        int intHintIndex;
        int intHintCount;
        int intCoinSelected;
        int intCoinsYellow;
        int intCoinsRed;
        int intCoinsBlue;
        int intCoinsGreen;
        int intCoinsYellowSpent;
        int intCoinsRedSpent;
        int intCoinsBlueSpent;
        int intCoinsGreenSpent;



        public Form1()
        {
            InitializeComponent();
            LoadData();

            numCoinYellow.Value = intCoinsYellow;
            numCoinRed.Value = intCoinsRed;
            numCoinBlue.Value = intCoinsBlue;
            numCoinGreen.Value = intCoinsGreen;
            if (filePath != string.Empty && boolFilePathValid == true)
                btnSpoiler.Text = filePath;
        }

        private void SaveData()
        {
            data[0] = intCoinsYellow.ToString();
            data[1] = intCoinsRed.ToString();
            data[2] = intCoinsBlue.ToString();
            data[3] = intCoinsGreen.ToString();
            data[4] = intCoinsYellowSpent.ToString();
            data[5] = intCoinsRedSpent.ToString();
            data[6] = intCoinsBlueSpent.ToString();
            data[7] = intCoinsGreenSpent.ToString();
            data[8] = filePath.ToString();
            data[9] = boolFilePathValid.ToString();

            if (boolShouldSaveFileLines == true)
            {
                data[10] = intHintListLength.ToString();
                string sb = "";
                if (fileLines != null)
                    for (int i = 0; i < fileLines.Length; i++)
                        sb += fileLines[i] + ",";
                data[11] = sb;
            }
            boolShouldSaveFileLines = false;

            for (int i = 0; i < intDataLines; i++)
                if (data[i] == null)
                    data[i] = "";

            if (fileSavePath != string.Empty)
                File.WriteAllLines(fileSavePath, data);
        }

        private void LoadData()
        {
            //CheckToCreateSaveData();

            //Read the contents of the file into a stream
            if (fileSavePath != string.Empty)
            {
                using (StreamReader reader = new StreamReader(fileSavePath))
                {
                    var list = new List<string>();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }

                    data = list.ToArray();

                    intCoinsYellow = Convert.ToInt32(data[0]);
                    intCoinsRed = Convert.ToInt32(data[1]);
                    intCoinsBlue = Convert.ToInt32(data[2]);
                    intCoinsGreen = Convert.ToInt32(data[3]);
                    intCoinsYellowSpent = Convert.ToInt32(data[4]);
                    intCoinsRedSpent = Convert.ToInt32(data[5]);
                    intCoinsBlueSpent = Convert.ToInt32(data[6]);
                    intCoinsGreenSpent = Convert.ToInt32(data[7]);
                    filePath = data[8];
                    boolFilePathValid = data[9].ToLower() == "true" ? true : false;
                    intHintListLength = Convert.ToInt32(data[10]);

                    if (intHintListLength > 0)
                        fileLines = new string[intHintListLength];
                    else
                        fileLines = new string[1];

                    string[] strFileLines = data[11].Split(',');
                    for (int i = 0; i < fileLines.Length; i++)
                        fileLines[i] = data[11] != "" ? strFileLines[i] : "";
                }
            }
        }


        private void PopulateComboBoxList(string filter)
        {

            if (cmbSelection.SelectedIndex < 0)
            {
                cmbSelection.BeginUpdate();
                if (boolSelected == false)
                    cmbSelection.Items.Clear();
                string fileName = string.Empty;
                switch (intCoinSelected)
                {
                    case 0: default: fileName = "ootmm_location_list.txt"; break;
                    case 1: case 2: fileName = "ootmm_item_list.txt"; break;
                }

                string resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Single(str => str.EndsWith(fileName));
                string[] strLocationList = ReadResource(resourceName).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                for (int i = 0; i < strLocationList.Length; i++)
                    if (strLocationList[i].ToLower().Contains(filter.Trim().ToLower()) || cmbSelection.Text == strSelectLocation || cmbSelection.Text == strSelectItem)
                        cmbSelection.Items.Add(strLocationList[i]);
                cmbSelection.EndUpdate();
                cmbSelection.Items.Add(" ");
            }

        }

        private bool CheckforValidLocation(string strHintCheck)
        {
            bool boolLocationValid = false;
            bool boolLocationExists = false;

            string fileName = "ootmm_location_list.txt";
            string resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Single(str => str.EndsWith(fileName));
            string[] strLocationList = ReadResource(resourceName).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < strLocationList.Length; i++)
                if (strLocationList[i].ToLower().Contains(strHintCheck.Trim().ToLower()))
                    boolLocationValid = true;

            //If Selected Location is a valid location, now check if it's in the spoiler log
            if (boolLocationValid)
            {
                for (int i = 0; i < fileLines.Length; i++)
                    if (fileLines[i].Contains(strHintCheck))
                        boolLocationExists = true;
            }

            if (boolLocationExists == true)
                return true;
            else
                return false;
        }

        private bool CheckforValidItem(string strHintCheck)
        {
            bool boolItemValid = false;
            bool boolItemExists = false;

            string fileName = "ootmm_item_list.txt";
            string resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Single(str => str.EndsWith(fileName));
            string[] strLocationList = ReadResource(resourceName).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < strLocationList.Length; i++)
                if (strLocationList[i].ToLower().Contains(strHintCheck.Trim().ToLower()))
                    boolItemValid = true;

            //Rename Bottle Hint since Empty Bottle might not exist, but Bottle with X Contents might exist.
            if (strHintCheck.Contains("Empty Bottle"))
                strHintCheck = "Bottle";

            //If Selected Item is a valid item, now check if it's in the spoiler log
            if (boolItemValid)
            {
                for (int i = 0; i < fileLines.Length; i++)
                    if (fileLines[i].Contains(strHintCheck))
                        boolItemExists = true;
            }

            if (boolItemExists == true)
                return true;
            else
                return false;
        }

        private void FindLocationHint(string strHintCheck)
        {
            int intHintStart = 0;
            int intHintEnd = fileLines.Length;
            string[] strHintList = new string[intHintListMax];
          
            ClearHintListArray();

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i] == strLocationListStart)
                    intHintStart = i;
            }

            //Extract Location Strings from Spoiler Log
            for (int i = intHintStart; i < intHintEnd; i++)
            {
                string strHint = string.Empty;
                string strHintLocation = string.Empty;

                if (fileLines[i].StartsWith("    "))
                {
                    strHint = fileLines[i].Substring(4, fileLines[i].Length - 4);
                    if (strHint.Contains(":"))
                        strHintLocation = strHint.Substring(0, strHint.IndexOf(":"));
                }

                if (strHintLocation.Equals(strHintCheck))
                {
                    strHintList[intHintIndex] = strHint;
                    intHintIndex++;
                }
            }

            for (int i = 0; i < strHintList.Length; i++)
            {
                if (strHintList[i] != null)
                {
                    strHintLocationList[i] = strHintList[i].Substring(0, strHintList[i].IndexOf(":"));
                    strHintItemList[i] = strHintList[i].Substring(strHintList[i].IndexOf(":") + 2, strHintList[i].Length - strHintList[i].IndexOf(":") - 2);
                }
            }

            intHintIndex = 0;
            intHintCount = 1;
            UpdateHintLabelText();
        }


        private void FindItemHint(string strHintCheck)
        {
            string strHintLocation = string.Empty;
            int intHintStart = 0;
            int intHintEnd = fileLines.Length;
            int intItemHintIndex = 0;

            ClearHintListArray();

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i].Contains(strLocationListStart))
                    intHintStart = i;
            }

            //Check for Item Name in Spoiler Log, then go backwards to get Item Location
            int j = 0;
            for (int i = intHintStart; i < intHintEnd; i++)
            {
                string strItemCheck = string.Empty;
                if (fileLines[i].StartsWith("    ") && !String.IsNullOrWhiteSpace(fileLines[i]))
                {
                    strItemCheck = fileLines[i].Substring(fileLines[i].IndexOf(":") + 2, fileLines[i].Length - fileLines[i].IndexOf(":") - 2);

                    if (strItemCheck.Contains(strHintCheck) || strHintCheck == "Bottle (MM)" && strItemCheck.Contains("Bottle") && strItemCheck.Contains("(MM)") ||
                        strHintCheck == "Bottle (OoT)" && strItemCheck.Contains("Bottle") && strItemCheck.Contains("(OoT)") || strHintCheck == "Bottle (OoT)" && fileLines[i].Contains("Ruto's Letter") ||
                        strHintCheck == "Bottle (MM)" && strItemCheck.Contains("Bottle of Gold Dust") || strHintCheck == "Bottle (MM)" && strItemCheck.Contains("Bottle of Chateau Romani"))
                    {
                        intItemHintIndex = i;

                        //Find Area Location of Item for Red Coin
                        if (intCoinSelected == 1)
                        {
                            bool boolPass = false;
                            while (boolPass == false)
                            {
                                intItemHintIndex--;
                                if (!fileLines[intItemHintIndex].StartsWith("    "))
                                {
                                    boolPass = true;
                                    strHintLocation = fileLines[intItemHintIndex];
                                    strHintLocationList[j] = strHintLocation.Substring(2, strHintLocation.IndexOf("(") - 3);
                                    strHintItemList[j] = strHintCheck;
                                    j++;
                                }
                            }
                        }

                        //Find Exact Location of Item for Blue Coin
                        else if (intCoinSelected == 2)
                        {
                            strHintLocationList[j] = fileLines[intItemHintIndex].Substring(0, fileLines[intItemHintIndex].IndexOf(":"));
                            strHintItemList[j] = strHintCheck;
                            j++;
                        }
                    }
                }
            }

            intHintIndex = 0;
            intHintCount = j;
            UpdateHintLabelText();
        }

        public void ClearHintListArray()
        {
            intHintIndex = 0;
            intHintCount = 0;

            for (int i = 0; i < intHintListMax; i++)
            {
                strHintItemList[i] = string.Empty;
                strHintLocationList[i] = string.Empty;
            }
        }

        private void UpdateCoinCount()
        {
            switch (intCoinSelected)
            {
                case 0:
                default:
                    intCoinsYellowSpent++;
                    lblCoinSpent.Text = "x " + intCoinsYellowSpent.ToString();
                    break;
                case 1:
                    intCoinsRedSpent++;
                    lblCoinSpent.Text = "x " + intCoinsRedSpent.ToString();
                    break;
                case 2:
                    intCoinsBlueSpent++;
                    lblCoinSpent.Text = "x " + intCoinsBlueSpent.ToString();
                    break;
            }

            SaveData();
        }

        private void UpdateHintLabelText()
        {
            string strHintArticle = " ";
            if (strHintItemList[intHintIndex].ToLower().StartsWith("a") || strHintItemList[intHintIndex].ToLower().StartsWith("e") || strHintItemList[intHintIndex].ToLower().StartsWith("i") ||
                strHintItemList[intHintIndex].ToLower().StartsWith("o") || strHintItemList[intHintIndex].ToLower().StartsWith("u"))
                strHintArticle = "n ";

            lblHint.Text = strHintLocationList[intHintIndex] + " hides a" + strHintArticle + strHintItemList[intHintIndex];
            lblHintNumber.Text = (intHintIndex + 1).ToString() + " of " + intHintCount.ToString();
        }

        /*private void CheckToCreateSaveData()
        {
            if (!File.Exists(fileSavePath))
            {
                if (!Directory.Exists(fileSaveDirectory))
                    Directory.CreateDirectory(fileSaveDirectory);
                SaveData();
            }
        }*/

        private void btnCoinSpend_Click(object sender, EventArgs e)
        {
            if (boolFilePathValid == false)
            {
                MessageBox.Show("Please first select an OoTMM Spoiler Log", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string strHintCheck = string.Empty;
                if (!string.IsNullOrEmpty(cmbSelection.Text))
                    strHintCheck = cmbSelection.Text;

                //Prompt User if they want to Spend Coin.
                DialogResult result = new DialogResult();
                switch (intCoinSelected)
                {
                    case 0:
                    default:
                        result = MessageBox.Show("Do you want to Spend a Yellow Coin to see what\n" + strHintCheck + " hides?", "Spend Yellow Coin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        break;
                    case 1:
                        result = MessageBox.Show("Do you want to Spend a Red Coin to see the general area(s)\n" + strHintCheck + " can be found?", "Spend Red Coin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        break;
                    case 2:
                        result = MessageBox.Show("Do you want to Spend a Blue Coin to see the exact location(s)\n" + strHintCheck + " can be found?", "Spend Blue Coin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        break;

                }

                //If Yes, check if item or location exists in item or location list.

                if (result == DialogResult.Yes)
                {
                    switch (intCoinSelected)
                    {
                        case 0:
                        default:
                            if (intCoinsYellowSpent < intCoinsYellow)
                            {
                                if (CheckforValidLocation(strHintCheck))
                                {
                                    FindLocationHint(strHintCheck);
                                    UpdateCoinCount();
                                }
                                else
                                {
                                    MessageBox.Show("Cannot find the location:\n" + strHintCheck + ".\nPlease select a different location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lblHint.Text = "Spend a Yellow Coin and select a location to see what it hides!";
                                }
                            }
                            else
                            {
                                MessageBox.Show("You do not have enough Yellow Coins for a hint.\nPlease try again when you find more.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblHint.Text = "Spend a Yellow Coin and select a location to see what it hides!";
                            }
                            break;
                        case 1:
                            if (intCoinsRedSpent < intCoinsRed)
                            {
                                if (CheckforValidItem(strHintCheck))
                                {
                                    FindItemHint(strHintCheck);
                                    UpdateCoinCount();
                                }
                                else
                                {
                                    MessageBox.Show("Cannot find the item:\n" + strHintCheck + ".\nPlease select a different item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lblHint.Text = "Spend a Red Coin and select an item to see the general area(s) it can be found!";
                                }
                            }
                            else
                            {
                                MessageBox.Show("You do not have enough Red Coins for a hint.\nPlease try again when you find more.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblHint.Text = "Spend a Red Coin and select an item to see the general area(s) it can be found!";
                            }
                            break;
                        case 2:
                            if (intCoinsBlueSpent < intCoinsBlue)
                            {

                                if (CheckforValidItem(strHintCheck))
                                {
                                    FindItemHint(strHintCheck);
                                    UpdateCoinCount();
                                }
                                else
                                {
                                    MessageBox.Show("Cannot find the item:" + strHintCheck + ".\nPlease select a different item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lblHint.Text = "Spend a Blue Coin and select an item to see the exact location(s) it can be found!";
                                }
                            }
                            else
                            {
                                MessageBox.Show("You do not have enough Blue Coins for a hint.\nPlease try again when you find more.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblHint.Text = "Spend a Blue Coin and select an item to see the exact location(s) it can be found!";
                            }
                            break;
                    }
                }
            }
        }

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelection.Enabled = false;
            cmbSelection.Enabled = true;
        }

        private void imgCoinYellow_Click(object sender, EventArgs e)
        {
            intCoinSelected = 0;
            HideCoinsScreen();
        }

        private void imgCoinRed_Click(object sender, EventArgs e)
        {
            intCoinSelected = 1;
            HideCoinsScreen();
        }

        private void imgCoinBlue_Click(object sender, EventArgs e)
        {
            intCoinSelected = 2;
            HideCoinsScreen();
        }

        private void imgCoinGreen_Click(object sender, EventArgs e)
        {
            intCoinSelected = 3;
            HideCoinsScreen();
        }

        private void btnHintNextLeft_Click(object sender, EventArgs e)
        {
            if (intHintIndex > 0 && !String.IsNullOrEmpty(strHintItemList[intHintIndex]))
            {
                intHintIndex--;
                UpdateHintLabelText();
            }

        }

        private void btnHintNextRight_Click(object sender, EventArgs e)
        {
            if (intHintIndex < intHintListMax && !String.IsNullOrEmpty(strHintItemList[intHintIndex]))
            {
                if (strHintLocationList[intHintIndex + 1] != string.Empty)
                {
                    intHintIndex++;
                    UpdateHintLabelText();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HideHintScreen();
        }


        private void HideCoinsScreen()
        {
            imgCoinYellow.Visible = false;
            imgCoinBlue.Visible = false;
            imgCoinGreen.Visible = false;
            imgCoinRed.Visible = false;
            lblXYellow.Visible = false;
            lblXBlue.Visible = false;
            lblXGreen.Visible = false;
            lblXRed.Visible = false;
            numCoinBlue.Visible = false;
            numCoinGreen.Visible = false;
            numCoinRed.Visible = false;
            numCoinYellow.Visible = false;
            lblHintsClick.Visible = false;
            imgCoinYellow.Enabled = false;
            imgCoinBlue.Enabled = false;
            imgCoinGreen.Enabled = false;
            imgCoinRed.Enabled = false;
            lblXYellow.Enabled = false;
            lblXBlue.Enabled = false;
            lblXGreen.Enabled = false;
            lblXRed.Enabled = false;
            numCoinBlue.Enabled = false;
            numCoinGreen.Enabled = false;
            numCoinRed.Enabled = false;
            numCoinYellow.Enabled = false;
            lblHintsClick.Enabled = false;

            imgCoinBig.Visible = true;
            lblCoinFound.Visible = true;
            lblFound.Visible = true;
            lblHint.Visible = true;
            btnBack.Visible = true;
            imgCoinBig.Enabled = true;
            lblCoinFound.Enabled = true;
            lblFound.Enabled = true;
            lblHint.Enabled = true;
            btnBack.Enabled = true;

            if (intCoinSelected != 3) // Not Green
            {
                lblSpoiler.Visible = true;
                btnSpoiler.Visible = true;
                lblCoinSpent.Visible = true;
                lblSpent.Visible = true;
                cmbSelection.Visible = true;
                btnCoinSpend.Visible = true;
                lblSpoiler.Enabled = true;
                btnSpoiler.Enabled = true;
                lblCoinSpent.Enabled = true;
                lblSpent.Enabled = true;
                cmbSelection.Enabled = true;
                btnCoinSpend.Enabled = true;
                lblHintNumber.Text = "1 of 1";

                if (intCoinSelected != 0) // Not Yellow
                {
                    lblHintNumber.Visible = true;
                    btnHintNextLeft.Visible = true;
                    btnHintNextRight.Visible = true;
                    lblHintNumber.Enabled = true;
                    btnHintNextLeft.Enabled = true;
                    btnHintNextRight.Enabled = true;
                }
            }
            else
            {
                btnReset.Visible = true;
                btnReset.Enabled = true;
            }

            cmbSelection.SelectedIndex = -1;
            boolSelected = false;

            switch (intCoinSelected)
            {
                case 0:
                    imgCoinBig.BackgroundImage = Properties.Resources.coin_yellow_big_purple;
                    lblCoinFound.Text = "x " + intCoinsYellow.ToString();
                    lblCoinSpent.Text = "x " + intCoinsYellowSpent.ToString();
                    btnCoinSpend.Text = "Spend a Yellow Coin";
                    lblHint.Text = "Spend a Yellow Coin and select a location to see what it hides!";
                    cmbSelection.Text = strSelectLocation;
                    PopulateComboBoxList(strSelectLocation);
                    break;
                case 1:
                    imgCoinBig.BackgroundImage = Properties.Resources.coin_red_big_purple;
                    lblCoinFound.Text = "x " + intCoinsRed.ToString();
                    lblCoinSpent.Text = "x " + intCoinsRedSpent.ToString();
                    btnCoinSpend.Text = "Spend a Red Coin";
                    lblHint.Text = "Spend a Red Coin and select an item to see the general area(s) it can be found!";
                    cmbSelection.Text = strSelectItem;
                    PopulateComboBoxList(strSelectItem);
                    break;
                case 2:
                    imgCoinBig.BackgroundImage = Properties.Resources.coin_blue_big_purple;
                    lblCoinFound.Text = "x " + intCoinsBlue.ToString();
                    lblCoinSpent.Text = "x " + intCoinsBlueSpent.ToString();
                    btnCoinSpend.Text = "Spend a Blue Coin";
                    lblHint.Text = "Spend a Blue Coin and select an item to see the exact location(s) it can be found!";
                    cmbSelection.Text = strSelectItem;
                    PopulateComboBoxList(strSelectItem);
                    break;
                case 3:
                    imgCoinBig.BackgroundImage = Properties.Resources.coin_green_big_purple;
                    lblCoinFound.Text = "x " + intCoinsGreen.ToString();
                    lblCoinSpent.Text = "x " + intCoinsGreenSpent.ToString();
                    lblHint.Text = "Green coins do not provide hints. Want to Reset all your Coins instead?";
                    break;
                default: imgCoinBig.BackgroundImage = Properties.Resources.coin_yellow_big_purple; break;
            }


        }

        private void HideHintScreen()
        {
            imgCoinYellow.Visible = true;
            imgCoinBlue.Visible = true;
            imgCoinGreen.Visible = true;
            imgCoinRed.Visible = true;
            lblXYellow.Visible = true;
            lblXBlue.Visible = true;
            lblXGreen.Visible = true;
            lblXRed.Visible = true;
            numCoinBlue.Visible = true;
            numCoinGreen.Visible = true;
            numCoinRed.Visible = true;
            numCoinYellow.Visible = true;
            lblHintsClick.Visible = true;
            imgCoinYellow.Enabled = true;
            imgCoinBlue.Enabled = true;
            imgCoinGreen.Enabled = true;
            imgCoinRed.Enabled = true;
            lblXYellow.Enabled = true;
            lblXBlue.Enabled = true;
            lblXGreen.Enabled = true;
            lblXRed.Enabled = true;
            numCoinBlue.Enabled = true;
            numCoinGreen.Enabled = true;
            numCoinRed.Enabled = true;
            numCoinYellow.Enabled = true;
            lblHintsClick.Enabled = true;

            imgCoinBig.Visible = false;
            lblSpoiler.Visible = false;
            btnSpoiler.Visible = false;
            lblCoinSpent.Visible = false;
            lblCoinFound.Visible = false;
            lblFound.Visible = false;
            lblSpent.Visible = false;
            cmbSelection.Visible = false;
            btnCoinSpend.Visible = false;
            lblHint.Visible = false;
            lblHintNumber.Visible = false;
            btnHintNextLeft.Visible = false;
            btnHintNextRight.Visible = false;
            btnBack.Visible = false;
            btnReset.Visible = false;
            imgCoinBig.Enabled = false;
            lblSpoiler.Enabled = false;
            btnSpoiler.Enabled = false;
            lblCoinSpent.Enabled = false;
            lblCoinFound.Enabled = false;
            lblFound.Enabled = false;
            lblSpent.Enabled = false;
            cmbSelection.Enabled = false;
            btnCoinSpend.Enabled = false;
            lblHint.Enabled = false;
            lblHintNumber.Enabled = false;
            btnHintNextLeft.Enabled = false;
            btnHintNextRight.Enabled = false;
            btnBack.Enabled = false;
            btnReset.Enabled = false;

            numCoinYellow.Value = intCoinsYellow;
            numCoinRed.Value = intCoinsRed;
            numCoinBlue.Value = intCoinsBlue;
            numCoinGreen.Value = intCoinsGreen;
        }

        public string ReadResource(string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(name))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private void numCoinYellow_Enter(object sender, EventArgs e)
        {
            numCoinYellow.Enabled = false;
            numCoinYellow.Enabled = true;
        }

        private void numCoinYellow_Click(object sender, EventArgs e)
        {
            numCoinYellow.Enabled = false;
            numCoinYellow.Enabled = true;
        }

        private void numCoinYellow_ValueChanged(object sender, EventArgs e)
        {
            numCoinYellow.Enabled = false;
            numCoinYellow.Enabled = true;
            intCoinsYellow = Convert.ToInt32(numCoinYellow.Value);
            SaveData();
        }

        private void numCoinRed_Click(object sender, EventArgs e)
        {
            numCoinRed.Enabled = false;
            numCoinRed.Enabled = true;
        }

        private void numCoinRed_Enter(object sender, EventArgs e)
        {
            numCoinRed.Enabled = false;
            numCoinRed.Enabled = true;
        }

        private void numCoinRed_ValueChanged(object sender, EventArgs e)
        {
            numCoinRed.Enabled = false;
            numCoinRed.Enabled = true;
            intCoinsRed = Convert.ToInt32(numCoinRed.Value);
            SaveData();
        }

        private void numCoinBlue_Click(object sender, EventArgs e)
        {
            numCoinBlue.Enabled = false;
            numCoinBlue.Enabled = true;
        }

        private void numCoinBlue_Enter(object sender, EventArgs e)
        {
            numCoinBlue.Enabled = false;
            numCoinBlue.Enabled = true;
        }

        private void numCoinBlue_ValueChanged(object sender, EventArgs e)
        {
            numCoinBlue.Enabled = false;
            numCoinBlue.Enabled = true;
            intCoinsBlue = Convert.ToInt32(numCoinBlue.Value);
            SaveData();
        }

        private void numCoinGreen_Click(object sender, EventArgs e)
        {
            numCoinGreen.Enabled = false;
            numCoinGreen.Enabled = true;
        }

        private void numCoinGreen_Enter(object sender, EventArgs e)
        {
            numCoinGreen.Enabled = false;
            numCoinGreen.Enabled = true;
        }

        private void numCoinGreen_ValueChanged(object sender, EventArgs e)
        {
            numCoinGreen.Enabled = false;
            numCoinGreen.Enabled = true;
            intCoinsGreen = Convert.ToInt32(numCoinGreen.Value);
            SaveData();
        }

        private void btnSpoiler_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var list = new List<string>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            list.Add(line);
                        }
                        fileLines = list.ToArray();
                    }

                    if (fileLines[0].StartsWith(strFirstLine))
                    {
                        boolFilePathValid = true;
                        btnSpoiler.Text = filePath;
                        intHintListLength = fileLines.Length;
                        fileSavePath = Path.GetDirectoryName(filePath) + @"\" + Path.GetFileName(Path.GetDirectoryName(filePath))+ "-HintsData.txt";
                        SaveData();
                    }
                    else
                    {
                        filePath = string.Empty;
                        for (int i = 0; i < fileLines.Length; i++)
                        {
                            fileLines[i] = string.Empty;
                        }
                        Array.Resize(ref fileLines, 1);
                        MessageBox.Show("Please select a valid OoTMM Spoiler Log.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Reset your Progress?", "Reset Seed?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                intCoinsYellow = 0;
                intCoinsRed = 0;
                intCoinsBlue = 0;
                intCoinsGreen = 0;
                intCoinsYellowSpent = 0;
                intCoinsRedSpent = 0;
                intCoinsBlueSpent = 0;
                intCoinsGreenSpent = 0;
                filePath = string.Empty;
                boolFilePathValid = false;
                intHintListLength = 0;
                fileLines = null;

                btnSpoiler.Text = "Select your OoTMM Spoiler Log";
                HideHintScreen();
            }
        }

        private void cmbSelection_TextChanged(object sender, EventArgs e)
        {
            PopulateComboBoxList(cmbSelection.Text);
            cmbSelection.Select(cmbSelection.Text.Length, 0);
        }

        private void cmbSelection_Click(object sender, EventArgs e)
        {
            boolSelected = false;
            cmbSelection.SelectionStart = 0;
            cmbSelection.SelectionLength = cmbSelection.Text.Length;
            cmbSelection.DroppedDown = true;
        }

        private void cmbSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            boolSelected = true;
        }

        private void cmbSelection_DropDownClosed(object sender, EventArgs e)
        {
            boolSelected = true;
        }

    }
}