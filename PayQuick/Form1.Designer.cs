namespace PayQuick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo20 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Next PayQuick Step", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Back to Previous PayQuick Step", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo2 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Delete Selected Employee", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo3 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Save Changes", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo4 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Add New Employee", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo5 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Update Employee", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo6 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("View / Edit Employee Info", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Employee", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lastname", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("firstname");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("identity_no");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("occupation");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("appointed_date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("status");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_tmp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_jan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_apr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_may");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_aug");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_oct");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_dec");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay_xtr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date_xtr");
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo7 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Next Employee in Payroll", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo8 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Previous Employee in Payroll", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo9 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Save Payroll Data", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo10 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Fetch Displayed Details From Employee Defaults", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo11 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Update Employee Defaults From Displayed Info", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo12 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Print Payslip", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo13 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Delete Entry from payroll", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo14 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Lock Down This Payroll", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Payroll", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lastname", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("firstname");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("identity_no");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("occupation");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("appointed_date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("tax_id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("status");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("basic_salary");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_value");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_earnings1_descr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("paye");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("uif");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("providend");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_value");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("other_deduction1_descr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("gross_pay");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("total_deduction");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("net_pay");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pay_date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("empID");
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem7 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem8 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem9 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem10 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem11 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem12 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem13 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem14 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem15 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo15 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Start FRESH Payroll", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo16 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Print Payslips for Payroll Employees", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo17 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Print Salary Schedule", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo18 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Print Payroll Summary", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolTip.UltraToolTipInfo ultraToolTipInfo19 = new Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Slot Payroll into Annual Totals", Infragistics.Win.ToolTipImage.Default, null, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab4 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab5 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PayQuick Options");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Employer Details");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("PayQuick Options");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Employer Details");
            this.ultraTabPageControl5 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox5 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraLabel25 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.btnNext = new Infragistics.Win.Misc.UltraButton();
            this.btnBack = new Infragistics.Win.Misc.UltraButton();
            this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraPanel3 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton5 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton4 = new Infragistics.Win.Misc.UltraButton();
            this.ultraSplitter2 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditor5 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PayQuick.DataSet1();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraTextEditor3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel24 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor6 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraComboEditor1 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraSplitter1 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraSplitter4 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraPanel6 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButton12 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton11 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton10 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton8 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton9 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton6 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton7 = new Infragistics.Win.Misc.UltraButton();
            this.ultraPanel5 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraGroupBox6 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox11 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTextEditor9 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor155 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGroupBox10 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTextEditor7 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditor157 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor156 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel20 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGroupBox9 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraMaskedEdit2 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel16 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEdit3 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraTextEditor8 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraMaskedEdit1 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraGroupBox8 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraMaskedEdit8 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEdit9 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel18 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEdit7 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel19 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraMaskedEdit6 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraTextEditor10 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraMaskedEdit5 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraGroupBox7 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraMaskedEdit4 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel28 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel27 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel26 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButton21 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton22 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton23 = new Infragistics.Win.Misc.UltraButton();
            this.ultraSplitter3 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraPanel4 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraSplitter5 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraPanel8 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraButton24 = new Infragistics.Win.Misc.UltraButton();
            this.ultraGrid2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraLabel23 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel7 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraComboEditor2 = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraButton13 = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel22 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel21 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTilePanel1 = new Infragistics.Win.Misc.UltraTilePanel();
            this.ultraTile1 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton14 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile2 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton15 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile3 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton16 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile8 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton25 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTabPageControl4 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraGroupBox4 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTilePanel2 = new Infragistics.Win.Misc.UltraTilePanel();
            this.ultraTile4 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton17 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile5 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton18 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile6 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton19 = new Infragistics.Win.Misc.UltraButton();
            this.ultraTile7 = new Infragistics.Win.Misc.UltraTile();
            this.ultraButton20 = new Infragistics.Win.Misc.UltraButton();
            this.tabWizard = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraToolTipManager1 = new Infragistics.Win.UltraWinToolTip.UltraToolTipManager(this.components);
            this._Form1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._Form1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraPrintPreviewDialog1 = new Infragistics.Win.Printing.UltraPrintPreviewDialog(this.components);
            this.ultraPrintDocument1 = new Infragistics.Win.Printing.UltraPrintDocument(this.components);
            this.employeeTableAdapter = new PayQuick.DataSet1TableAdapters.EmployeeTableAdapter();
            this.payrollTableAdapter = new PayQuick.DataSet1TableAdapters.PayrollTableAdapter();
            this.employerTableAdapter = new PayQuick.DataSet1TableAdapters.EmployerTableAdapter();
            this.OptionsTableAdapter = new PayQuick.DataSet1TableAdapters.OptionsTableAdapter();
            this.tableAdapterManager = new PayQuick.DataSet1TableAdapters.TableAdapterManager();
            this.OptionsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employerbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLock1 = new QALock.TLock(this.components);
            this.ultraTabPageControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox5)).BeginInit();
            this.ultraGroupBox5.SuspendLayout();
            this.ultraTabPageControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            this.ultraPanel3.ClientArea.SuspendLayout();
            this.ultraPanel3.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.ultraTabPageControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            this.ultraPanel6.ClientArea.SuspendLayout();
            this.ultraPanel6.SuspendLayout();
            this.ultraPanel5.ClientArea.SuspendLayout();
            this.ultraPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox6)).BeginInit();
            this.ultraGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox11)).BeginInit();
            this.ultraGroupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor155)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox10)).BeginInit();
            this.ultraGroupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor157)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor156)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox9)).BeginInit();
            this.ultraGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox8)).BeginInit();
            this.ultraGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox7)).BeginInit();
            this.ultraGroupBox7.SuspendLayout();
            this.ultraPanel4.ClientArea.SuspendLayout();
            this.ultraPanel4.SuspendLayout();
            this.ultraPanel8.ClientArea.SuspendLayout();
            this.ultraPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).BeginInit();
            this.ultraPanel7.ClientArea.SuspendLayout();
            this.ultraPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).BeginInit();
            this.ultraTabPageControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).BeginInit();
            this.ultraTilePanel1.SuspendLayout();
            this.ultraTile1.SuspendLayout();
            this.ultraTile2.SuspendLayout();
            this.ultraTile3.SuspendLayout();
            this.ultraTile8.SuspendLayout();
            this.ultraTabPageControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).BeginInit();
            this.ultraGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel2)).BeginInit();
            this.ultraTilePanel2.SuspendLayout();
            this.ultraTile4.SuspendLayout();
            this.ultraTile5.SuspendLayout();
            this.ultraTile6.SuspendLayout();
            this.ultraTile7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabWizard)).BeginInit();
            this.tabWizard.SuspendLayout();
            this.ultraTabSharedControlsPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTabPageControl5
            // 
            this.ultraTabPageControl5.Controls.Add(this.ultraGroupBox5);
            this.ultraTabPageControl5.Controls.Add(this.btnNext);
            this.ultraTabPageControl5.Controls.Add(this.btnBack);
            this.ultraTabPageControl5.Location = new System.Drawing.Point(0, 0);
            this.ultraTabPageControl5.Name = "ultraTabPageControl5";
            this.ultraTabPageControl5.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraGroupBox5
            // 
            this.ultraGroupBox5.Controls.Add(this.ultraLabel25);
            this.ultraGroupBox5.Controls.Add(this.ultraLabel1);
            this.ultraGroupBox5.Controls.Add(this.ultraPictureBox1);
            this.ultraGroupBox5.Location = new System.Drawing.Point(4, 4);
            this.ultraGroupBox5.Name = "ultraGroupBox5";
            this.ultraGroupBox5.Size = new System.Drawing.Size(1049, 478);
            this.ultraGroupBox5.TabIndex = 4;
            // 
            // ultraLabel25
            // 
            this.ultraLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.TextHAlignAsString = "Center";
            this.ultraLabel25.Appearance = appearance1;
            this.ultraLabel25.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel25.Location = new System.Drawing.Point(325, 79);
            this.ultraLabel25.Name = "ultraLabel25";
            this.ultraLabel25.Size = new System.Drawing.Size(382, 46);
            this.ultraLabel25.TabIndex = 2;
            this.ultraLabel25.Text = "Simplified Payroll";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.TextHAlignAsString = "Center";
            this.ultraLabel1.Appearance = appearance2;
            this.ultraLabel1.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(152, 6);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(737, 79);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "PayQuick";
            // 
            // ultraPictureBox1
            // 
            this.ultraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBox1.Image = ((object)(resources.GetObject("ultraPictureBox1.Image")));
            this.ultraPictureBox1.Location = new System.Drawing.Point(34, 108);
            this.ultraPictureBox1.Name = "ultraPictureBox1";
            this.ultraPictureBox1.Size = new System.Drawing.Size(967, 352);
            this.ultraPictureBox1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.Image = ((object)(resources.GetObject("appearance3.Image")));
            appearance3.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.btnNext.Appearance = appearance3;
            this.btnNext.ImageSize = new System.Drawing.Size(48, 48);
            this.btnNext.Location = new System.Drawing.Point(936, 492);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            ultraToolTipInfo20.ToolTipText = "Next PayQuick Step";
            this.ultraToolTipManager1.SetUltraToolTip(this.btnNext, ultraToolTipInfo20);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            appearance4.Image = ((object)(resources.GetObject("appearance4.Image")));
            appearance4.ImageHAlign = Infragistics.Win.HAlign.Left;
            this.btnBack.Appearance = appearance4;
            this.btnBack.ImageSize = new System.Drawing.Size(48, 48);
            this.btnBack.Location = new System.Drawing.Point(7, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 49);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            ultraToolTipInfo1.ToolTipText = "Back to Previous PayQuick Step";
            this.ultraToolTipManager1.SetUltraToolTip(this.btnBack, ultraToolTipInfo1);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ultraTabPageControl1
            // 
            this.ultraTabPageControl1.Controls.Add(this.ultraGroupBox1);
            this.ultraTabPageControl1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl1.Name = "ultraTabPageControl1";
            this.ultraTabPageControl1.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraPanel3);
            this.ultraGroupBox1.Controls.Add(this.ultraSplitter2);
            this.ultraGroupBox1.Controls.Add(this.ultraPanel2);
            this.ultraGroupBox1.Controls.Add(this.ultraSplitter1);
            this.ultraGroupBox1.Controls.Add(this.ultraPanel1);
            this.ultraGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1049, 478);
            this.ultraGroupBox1.TabIndex = 2;
            this.ultraGroupBox1.Text = "Page 1 of 4 - Manage Employees";
            // 
            // ultraPanel3
            // 
            // 
            // ultraPanel3.ClientArea
            // 
            this.ultraPanel3.ClientArea.Controls.Add(this.ultraButton3);
            this.ultraPanel3.ClientArea.Controls.Add(this.ultraButton5);
            this.ultraPanel3.ClientArea.Controls.Add(this.ultraButton1);
            this.ultraPanel3.ClientArea.Controls.Add(this.ultraButton4);
            this.ultraPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraPanel3.Location = new System.Drawing.Point(820, 16);
            this.ultraPanel3.Name = "ultraPanel3";
            this.ultraPanel3.Size = new System.Drawing.Size(240, 459);
            this.ultraPanel3.TabIndex = 9;
            // 
            // ultraButton3
            // 
            appearance5.Image = ((object)(resources.GetObject("appearance5.Image")));
            appearance5.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton3.Appearance = appearance5;
            this.ultraButton3.ImageSize = new System.Drawing.Size(64, 64);
            this.ultraButton3.Location = new System.Drawing.Point(7, 277);
            this.ultraButton3.Name = "ultraButton3";
            this.ultraButton3.Size = new System.Drawing.Size(221, 76);
            this.ultraButton3.TabIndex = 17;
            ultraToolTipInfo2.ToolTipText = "Delete Selected Employee";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton3, ultraToolTipInfo2);
            this.ultraButton3.Click += new System.EventHandler(this.ultraButton3_Click);
            // 
            // ultraButton5
            // 
            appearance6.Image = ((object)(resources.GetObject("appearance6.Image")));
            appearance6.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton5.Appearance = appearance6;
            this.ultraButton5.ImageSize = new System.Drawing.Size(64, 64);
            this.ultraButton5.Location = new System.Drawing.Point(7, 370);
            this.ultraButton5.Name = "ultraButton5";
            this.ultraButton5.Size = new System.Drawing.Size(221, 76);
            this.ultraButton5.TabIndex = 18;
            ultraToolTipInfo3.ToolTipText = "Save Changes";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton5, ultraToolTipInfo3);
            this.ultraButton5.Click += new System.EventHandler(this.ultraButton5_Click_1);
            // 
            // ultraButton1
            // 
            appearance7.Image = ((object)(resources.GetObject("appearance7.Image")));
            appearance7.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton1.Appearance = appearance7;
            this.ultraButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.ultraButton1.Location = new System.Drawing.Point(7, 195);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(221, 76);
            this.ultraButton1.TabIndex = 1;
            ultraToolTipInfo4.ToolTipText = "Add New Employee";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton1, ultraToolTipInfo4);
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ultraButton4
            // 
            this.ultraButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance8.Image = ((object)(resources.GetObject("appearance8.Image")));
            appearance8.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton4.Appearance = appearance8;
            this.ultraButton4.ImageSize = new System.Drawing.Size(128, 128);
            this.ultraButton4.Location = new System.Drawing.Point(7, 4);
            this.ultraButton4.Name = "ultraButton4";
            this.ultraButton4.Size = new System.Drawing.Size(221, 76);
            this.ultraButton4.TabIndex = 14;
            ultraToolTipInfo5.ToolTipText = "Update Employee";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton4, ultraToolTipInfo5);
            this.ultraButton4.Click += new System.EventHandler(this.ultraButton4_Click);
            // 
            // ultraSplitter2
            // 
            this.ultraSplitter2.Location = new System.Drawing.Point(814, 16);
            this.ultraSplitter2.Name = "ultraSplitter2";
            this.ultraSplitter2.RestoreExtent = 0;
            this.ultraSplitter2.Size = new System.Drawing.Size(6, 459);
            this.ultraSplitter2.TabIndex = 8;
            // 
            // ultraPanel2
            // 
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraButton2);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor5);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor1);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor2);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraDateTimeEditor1);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor3);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor4);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel24);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraTextEditor6);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraComboEditor1);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel2);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel3);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel8);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel4);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel7);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel5);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel6);
            this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraPanel2.Location = new System.Drawing.Point(525, 16);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(289, 459);
            this.ultraPanel2.TabIndex = 7;
            // 
            // ultraButton2
            // 
            appearance9.Image = ((object)(resources.GetObject("appearance9.Image")));
            appearance9.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton2.Appearance = appearance9;
            this.ultraButton2.ImageSize = new System.Drawing.Size(96, 96);
            this.ultraButton2.Location = new System.Drawing.Point(6, 337);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(277, 109);
            this.ultraButton2.TabIndex = 16;
            ultraToolTipInfo6.ToolTipText = "View / Edit Employee Info";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton2, ultraToolTipInfo6);
            this.ultraButton2.Click += new System.EventHandler(this.ultraButton2_Click);
            // 
            // ultraTextEditor5
            // 
            this.ultraTextEditor5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "identity_no", true));
            this.ultraTextEditor5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor5.Location = new System.Drawing.Point(100, 172);
            this.ultraTextEditor5.Name = "ultraTextEditor5";
            this.ultraTextEditor5.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor5.TabIndex = 4;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSet1;
            this.employeeBindingSource.Sort = "lastname";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "pay_id", true));
            this.ultraTextEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor1.Location = new System.Drawing.Point(100, 8);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor1.TabIndex = 0;
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "lastname", true));
            this.ultraTextEditor2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor2.Location = new System.Drawing.Point(100, 49);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor2.TabIndex = 1;
            // 
            // ultraDateTimeEditor1
            // 
            this.ultraDateTimeEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "appointed_date", true));
            this.ultraDateTimeEditor1.DateTime = new System.DateTime(2017, 3, 15, 0, 0, 0, 0);
            this.ultraDateTimeEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraDateTimeEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDateTimeEditor1.Location = new System.Drawing.Point(100, 254);
            this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
            this.ultraDateTimeEditor1.Size = new System.Drawing.Size(183, 34);
            this.ultraDateTimeEditor1.TabIndex = 18;
            this.ultraDateTimeEditor1.Value = new System.DateTime(2017, 3, 15, 0, 0, 0, 0);
            // 
            // ultraTextEditor3
            // 
            this.ultraTextEditor3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "firstname", true));
            this.ultraTextEditor3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor3.Location = new System.Drawing.Point(100, 90);
            this.ultraTextEditor3.Name = "ultraTextEditor3";
            this.ultraTextEditor3.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor3.TabIndex = 2;
            // 
            // ultraTextEditor4
            // 
            this.ultraTextEditor4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "occupation", true));
            this.ultraTextEditor4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor4.Location = new System.Drawing.Point(100, 131);
            this.ultraTextEditor4.Name = "ultraTextEditor4";
            this.ultraTextEditor4.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor4.TabIndex = 3;
            // 
            // ultraLabel24
            // 
            this.ultraLabel24.Location = new System.Drawing.Point(4, 263);
            this.ultraLabel24.Name = "ultraLabel24";
            this.ultraLabel24.Size = new System.Drawing.Size(90, 16);
            this.ultraLabel24.TabIndex = 17;
            this.ultraLabel24.Text = "Employ Start:";
            // 
            // ultraTextEditor6
            // 
            this.ultraTextEditor6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "tax_id", true));
            this.ultraTextEditor6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor6.Location = new System.Drawing.Point(100, 213);
            this.ultraTextEditor6.Name = "ultraTextEditor6";
            this.ultraTextEditor6.Size = new System.Drawing.Size(183, 34);
            this.ultraTextEditor6.TabIndex = 5;
            // 
            // ultraComboEditor1
            // 
            this.ultraComboEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "status", true));
            this.ultraComboEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraComboEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valueListItem1.DataValue = "ValueListItem0";
            valueListItem1.DisplayText = "Active";
            valueListItem2.DataValue = "ValueListItem1";
            valueListItem2.DisplayText = "Dormant";
            this.ultraComboEditor1.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.ultraComboEditor1.Location = new System.Drawing.Point(100, 295);
            this.ultraComboEditor1.Name = "ultraComboEditor1";
            this.ultraComboEditor1.Size = new System.Drawing.Size(183, 34);
            this.ultraComboEditor1.TabIndex = 16;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(4, 17);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(66, 17);
            this.ultraLabel2.TabIndex = 7;
            this.ultraLabel2.Text = "Empl. no.:";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(4, 58);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(66, 16);
            this.ultraLabel3.TabIndex = 8;
            this.ultraLabel3.Text = "Surname:";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(4, 304);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(90, 17);
            this.ultraLabel8.TabIndex = 13;
            this.ultraLabel8.Text = "Active/Dormant:";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(4, 100);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(66, 15);
            this.ultraLabel4.TabIndex = 9;
            this.ultraLabel4.Text = "First Name:";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(4, 224);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(66, 12);
            this.ultraLabel7.TabIndex = 12;
            this.ultraLabel7.Text = "SARS no.:";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(4, 141);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(66, 14);
            this.ultraLabel5.TabIndex = 10;
            this.ultraLabel5.Text = "Occupation:";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(4, 183);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(66, 13);
            this.ultraLabel6.TabIndex = 11;
            this.ultraLabel6.Text = "ID no.:";
            // 
            // ultraSplitter1
            // 
            this.ultraSplitter1.Location = new System.Drawing.Point(519, 16);
            this.ultraSplitter1.Name = "ultraSplitter1";
            this.ultraSplitter1.RestoreExtent = 0;
            this.ultraSplitter1.Size = new System.Drawing.Size(6, 459);
            this.ultraSplitter1.TabIndex = 6;
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraGrid1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraPanel1.Location = new System.Drawing.Point(3, 16);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(516, 459);
            this.ultraPanel1.TabIndex = 4;
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.employeeBindingSource;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance10;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.Caption = "Surname";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 120;
            ultraGridColumn3.Header.Caption = "First Name";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.Caption = "ID Number";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.Header.Caption = "Empl.No.";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn6.Header.Caption = "Occupation";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 102;
            ultraGridColumn7.Header.VisiblePosition = 161;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.Header.VisiblePosition = 6;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.Caption = "Actv/Dormant";
            ultraGridColumn9.Header.VisiblePosition = 162;
            ultraGridColumn9.Width = 90;
            ultraGridColumn10.Header.VisiblePosition = 7;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 8;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 9;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.Header.VisiblePosition = 10;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.Header.VisiblePosition = 11;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.Header.VisiblePosition = 12;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 13;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 14;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 15;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn19.Header.VisiblePosition = 16;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 17;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn21.Header.VisiblePosition = 163;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.Header.VisiblePosition = 18;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn23.Header.VisiblePosition = 19;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.Header.VisiblePosition = 20;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn25.Header.VisiblePosition = 21;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn26.Header.VisiblePosition = 22;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn27.Header.VisiblePosition = 23;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn28.Header.VisiblePosition = 24;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn29.Header.VisiblePosition = 25;
            ultraGridColumn29.Hidden = true;
            ultraGridColumn30.Header.VisiblePosition = 26;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn31.Header.VisiblePosition = 27;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn32.Header.VisiblePosition = 28;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.Header.VisiblePosition = 164;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 29;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.Header.VisiblePosition = 30;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.Header.VisiblePosition = 31;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.Header.VisiblePosition = 32;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn38.Header.VisiblePosition = 33;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.Header.VisiblePosition = 34;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn40.Header.VisiblePosition = 35;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn41.Header.VisiblePosition = 36;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn42.Header.VisiblePosition = 37;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn43.Header.VisiblePosition = 38;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.Header.VisiblePosition = 39;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn45.Header.VisiblePosition = 165;
            ultraGridColumn45.Hidden = true;
            ultraGridColumn46.Header.VisiblePosition = 40;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn47.Header.VisiblePosition = 41;
            ultraGridColumn47.Hidden = true;
            ultraGridColumn48.Header.VisiblePosition = 42;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn49.Header.VisiblePosition = 43;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn50.Header.VisiblePosition = 44;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn51.Header.VisiblePosition = 45;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn52.Header.VisiblePosition = 46;
            ultraGridColumn52.Hidden = true;
            ultraGridColumn53.Header.VisiblePosition = 47;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn54.Header.VisiblePosition = 48;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn55.Header.VisiblePosition = 49;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.Header.VisiblePosition = 50;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn57.Header.VisiblePosition = 166;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn58.Header.VisiblePosition = 51;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.Header.VisiblePosition = 52;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn60.Header.VisiblePosition = 53;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.Header.VisiblePosition = 54;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn62.Header.VisiblePosition = 55;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn63.Header.VisiblePosition = 56;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.Header.VisiblePosition = 57;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn65.Header.VisiblePosition = 58;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.Header.VisiblePosition = 59;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn67.Header.VisiblePosition = 60;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.Header.VisiblePosition = 61;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn69.Header.VisiblePosition = 167;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn70.Header.VisiblePosition = 62;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.Header.VisiblePosition = 63;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn72.Header.VisiblePosition = 64;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.Header.VisiblePosition = 65;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn74.Header.VisiblePosition = 66;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn75.Header.VisiblePosition = 67;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn76.Header.VisiblePosition = 68;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn77.Header.VisiblePosition = 69;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn78.Header.VisiblePosition = 70;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn79.Header.VisiblePosition = 71;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn80.Header.VisiblePosition = 72;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn81.Header.VisiblePosition = 168;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn82.Header.VisiblePosition = 73;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.Header.VisiblePosition = 74;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn84.Header.VisiblePosition = 75;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn85.Header.VisiblePosition = 76;
            ultraGridColumn85.Hidden = true;
            ultraGridColumn86.Header.VisiblePosition = 77;
            ultraGridColumn86.Hidden = true;
            ultraGridColumn87.Header.VisiblePosition = 78;
            ultraGridColumn87.Hidden = true;
            ultraGridColumn88.Header.VisiblePosition = 79;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn89.Header.VisiblePosition = 80;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn90.Header.VisiblePosition = 81;
            ultraGridColumn90.Hidden = true;
            ultraGridColumn91.Header.VisiblePosition = 82;
            ultraGridColumn91.Hidden = true;
            ultraGridColumn92.Header.VisiblePosition = 83;
            ultraGridColumn92.Hidden = true;
            ultraGridColumn93.Header.VisiblePosition = 169;
            ultraGridColumn93.Hidden = true;
            ultraGridColumn94.Header.VisiblePosition = 84;
            ultraGridColumn94.Hidden = true;
            ultraGridColumn95.Header.VisiblePosition = 85;
            ultraGridColumn95.Hidden = true;
            ultraGridColumn96.Header.VisiblePosition = 86;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn97.Header.VisiblePosition = 87;
            ultraGridColumn97.Hidden = true;
            ultraGridColumn98.Header.VisiblePosition = 88;
            ultraGridColumn98.Hidden = true;
            ultraGridColumn99.Header.VisiblePosition = 89;
            ultraGridColumn99.Hidden = true;
            ultraGridColumn100.Header.VisiblePosition = 90;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn101.Header.VisiblePosition = 91;
            ultraGridColumn101.Hidden = true;
            ultraGridColumn102.Header.VisiblePosition = 92;
            ultraGridColumn102.Hidden = true;
            ultraGridColumn103.Header.VisiblePosition = 93;
            ultraGridColumn103.Hidden = true;
            ultraGridColumn104.Header.VisiblePosition = 94;
            ultraGridColumn104.Hidden = true;
            ultraGridColumn105.Header.VisiblePosition = 170;
            ultraGridColumn105.Hidden = true;
            ultraGridColumn106.Header.VisiblePosition = 95;
            ultraGridColumn106.Hidden = true;
            ultraGridColumn107.Header.VisiblePosition = 96;
            ultraGridColumn107.Hidden = true;
            ultraGridColumn108.Header.VisiblePosition = 97;
            ultraGridColumn108.Hidden = true;
            ultraGridColumn109.Header.VisiblePosition = 98;
            ultraGridColumn109.Hidden = true;
            ultraGridColumn110.Header.VisiblePosition = 99;
            ultraGridColumn110.Hidden = true;
            ultraGridColumn111.Header.VisiblePosition = 100;
            ultraGridColumn111.Hidden = true;
            ultraGridColumn112.Header.VisiblePosition = 101;
            ultraGridColumn112.Hidden = true;
            ultraGridColumn113.Header.VisiblePosition = 102;
            ultraGridColumn113.Hidden = true;
            ultraGridColumn114.Header.VisiblePosition = 103;
            ultraGridColumn114.Hidden = true;
            ultraGridColumn115.Header.VisiblePosition = 104;
            ultraGridColumn115.Hidden = true;
            ultraGridColumn116.Header.VisiblePosition = 105;
            ultraGridColumn116.Hidden = true;
            ultraGridColumn117.Header.VisiblePosition = 171;
            ultraGridColumn117.Hidden = true;
            ultraGridColumn118.Header.VisiblePosition = 106;
            ultraGridColumn118.Hidden = true;
            ultraGridColumn119.Header.VisiblePosition = 107;
            ultraGridColumn119.Hidden = true;
            ultraGridColumn120.Header.VisiblePosition = 108;
            ultraGridColumn120.Hidden = true;
            ultraGridColumn121.Header.VisiblePosition = 109;
            ultraGridColumn121.Hidden = true;
            ultraGridColumn122.Header.VisiblePosition = 110;
            ultraGridColumn122.Hidden = true;
            ultraGridColumn123.Header.VisiblePosition = 111;
            ultraGridColumn123.Hidden = true;
            ultraGridColumn124.Header.VisiblePosition = 112;
            ultraGridColumn124.Hidden = true;
            ultraGridColumn125.Header.VisiblePosition = 113;
            ultraGridColumn125.Hidden = true;
            ultraGridColumn126.Header.VisiblePosition = 114;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn127.Header.VisiblePosition = 115;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn128.Header.VisiblePosition = 116;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn129.Header.VisiblePosition = 172;
            ultraGridColumn129.Hidden = true;
            ultraGridColumn130.Header.VisiblePosition = 117;
            ultraGridColumn130.Hidden = true;
            ultraGridColumn131.Header.VisiblePosition = 118;
            ultraGridColumn131.Hidden = true;
            ultraGridColumn132.Header.VisiblePosition = 119;
            ultraGridColumn132.Hidden = true;
            ultraGridColumn133.Header.VisiblePosition = 120;
            ultraGridColumn133.Hidden = true;
            ultraGridColumn134.Header.VisiblePosition = 121;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn135.Header.VisiblePosition = 122;
            ultraGridColumn135.Hidden = true;
            ultraGridColumn136.Header.VisiblePosition = 123;
            ultraGridColumn136.Hidden = true;
            ultraGridColumn137.Header.VisiblePosition = 124;
            ultraGridColumn137.Hidden = true;
            ultraGridColumn138.Header.VisiblePosition = 125;
            ultraGridColumn138.Hidden = true;
            ultraGridColumn139.Header.VisiblePosition = 126;
            ultraGridColumn139.Hidden = true;
            ultraGridColumn140.Header.VisiblePosition = 127;
            ultraGridColumn140.Hidden = true;
            ultraGridColumn141.Header.VisiblePosition = 173;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn142.Header.VisiblePosition = 128;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn143.Header.VisiblePosition = 129;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn144.Header.VisiblePosition = 130;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn145.Header.VisiblePosition = 131;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn146.Header.VisiblePosition = 132;
            ultraGridColumn146.Hidden = true;
            ultraGridColumn147.Header.VisiblePosition = 133;
            ultraGridColumn147.Hidden = true;
            ultraGridColumn148.Header.VisiblePosition = 134;
            ultraGridColumn148.Hidden = true;
            ultraGridColumn149.Header.VisiblePosition = 135;
            ultraGridColumn149.Hidden = true;
            ultraGridColumn150.Header.VisiblePosition = 136;
            ultraGridColumn150.Hidden = true;
            ultraGridColumn151.Header.VisiblePosition = 137;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn152.Header.VisiblePosition = 138;
            ultraGridColumn152.Hidden = true;
            ultraGridColumn153.Header.VisiblePosition = 174;
            ultraGridColumn153.Hidden = true;
            ultraGridColumn154.Header.VisiblePosition = 139;
            ultraGridColumn154.Hidden = true;
            ultraGridColumn155.Header.VisiblePosition = 140;
            ultraGridColumn155.Hidden = true;
            ultraGridColumn156.Header.VisiblePosition = 141;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn157.Header.VisiblePosition = 142;
            ultraGridColumn157.Hidden = true;
            ultraGridColumn158.Header.VisiblePosition = 143;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn159.Header.VisiblePosition = 144;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn160.Header.VisiblePosition = 145;
            ultraGridColumn160.Hidden = true;
            ultraGridColumn161.Header.VisiblePosition = 146;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn162.Header.VisiblePosition = 147;
            ultraGridColumn162.Hidden = true;
            ultraGridColumn163.Header.VisiblePosition = 148;
            ultraGridColumn163.Hidden = true;
            ultraGridColumn164.Header.VisiblePosition = 149;
            ultraGridColumn164.Hidden = true;
            ultraGridColumn165.Header.VisiblePosition = 175;
            ultraGridColumn165.Hidden = true;
            ultraGridColumn166.Header.VisiblePosition = 150;
            ultraGridColumn166.Hidden = true;
            ultraGridColumn167.Header.VisiblePosition = 151;
            ultraGridColumn167.Hidden = true;
            ultraGridColumn168.Header.VisiblePosition = 152;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn169.Header.VisiblePosition = 153;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn170.Header.VisiblePosition = 154;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn171.Header.VisiblePosition = 155;
            ultraGridColumn171.Hidden = true;
            ultraGridColumn172.Header.VisiblePosition = 156;
            ultraGridColumn172.Hidden = true;
            ultraGridColumn173.Header.VisiblePosition = 157;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn174.Header.VisiblePosition = 158;
            ultraGridColumn174.Hidden = true;
            ultraGridColumn175.Header.VisiblePosition = 159;
            ultraGridColumn175.Hidden = true;
            ultraGridColumn176.Header.VisiblePosition = 160;
            ultraGridColumn176.Hidden = true;
            ultraGridColumn177.Header.VisiblePosition = 176;
            ultraGridColumn177.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77,
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85,
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88,
            ultraGridColumn89,
            ultraGridColumn90,
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105,
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111,
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122,
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130,
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145,
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150,
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160,
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164,
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172,
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance11;
            appearance12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.GroupByBox.Hidden = true;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance13.BackColor2 = System.Drawing.SystemColors.Control;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance13;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance14.BackColor = System.Drawing.SystemColors.Window;
            appearance14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Highlight;
            appearance15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance15;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance16;
            appearance17.BorderColor = System.Drawing.Color.Silver;
            appearance17.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance17;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance18.BackColor = System.Drawing.SystemColors.Control;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance18.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance18;
            appearance19.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance19;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance20.BackColor = System.Drawing.SystemColors.Window;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance20;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance21;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(516, 459);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // ultraTabPageControl2
            // 
            this.ultraTabPageControl2.Controls.Add(this.ultraGroupBox2);
            this.ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl2.Name = "ultraTabPageControl2";
            this.ultraTabPageControl2.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.ultraSplitter4);
            this.ultraGroupBox2.Controls.Add(this.ultraPanel6);
            this.ultraGroupBox2.Controls.Add(this.ultraPanel5);
            this.ultraGroupBox2.Controls.Add(this.ultraSplitter3);
            this.ultraGroupBox2.Controls.Add(this.ultraPanel4);
            this.ultraGroupBox2.Location = new System.Drawing.Point(4, 4);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(1049, 478);
            this.ultraGroupBox2.TabIndex = 3;
            this.ultraGroupBox2.Text = "Page 2 of 4 - Process Salaries";
            // 
            // ultraSplitter4
            // 
            this.ultraSplitter4.BackColor = System.Drawing.Color.MintCream;
            this.ultraSplitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraSplitter4.Location = new System.Drawing.Point(205, 405);
            this.ultraSplitter4.Name = "ultraSplitter4";
            this.ultraSplitter4.RestoreExtent = 84;
            this.ultraSplitter4.Size = new System.Drawing.Size(841, 10);
            this.ultraSplitter4.TabIndex = 19;
            // 
            // ultraPanel6
            // 
            // 
            // ultraPanel6.ClientArea
            // 
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton12);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton11);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton10);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton8);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton9);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton6);
            this.ultraPanel6.ClientArea.Controls.Add(this.ultraButton7);
            this.ultraPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraPanel6.Location = new System.Drawing.Point(205, 415);
            this.ultraPanel6.Name = "ultraPanel6";
            this.ultraPanel6.Size = new System.Drawing.Size(841, 60);
            this.ultraPanel6.TabIndex = 18;
            // 
            // ultraButton12
            // 
            appearance22.Image = ((object)(resources.GetObject("appearance22.Image")));
            appearance22.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton12.Appearance = appearance22;
            this.ultraButton12.ImageSize = new System.Drawing.Size(48, 48);
            this.ultraButton12.Location = new System.Drawing.Point(719, 6);
            this.ultraButton12.Name = "ultraButton12";
            this.ultraButton12.Size = new System.Drawing.Size(115, 51);
            this.ultraButton12.TabIndex = 17;
            ultraToolTipInfo7.ToolTipText = "Next Employee in Payroll";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton12, ultraToolTipInfo7);
            this.ultraButton12.Click += new System.EventHandler(this.ultraButton12_Click);
            // 
            // ultraButton11
            // 
            appearance23.Image = ((object)(resources.GetObject("appearance23.Image")));
            appearance23.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton11.Appearance = appearance23;
            this.ultraButton11.ImageSize = new System.Drawing.Size(48, 48);
            this.ultraButton11.Location = new System.Drawing.Point(602, 6);
            this.ultraButton11.Name = "ultraButton11";
            this.ultraButton11.Size = new System.Drawing.Size(115, 51);
            this.ultraButton11.TabIndex = 16;
            ultraToolTipInfo8.ToolTipText = "Previous Employee in Payroll";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton11, ultraToolTipInfo8);
            this.ultraButton11.Click += new System.EventHandler(this.ultraButton11_Click);
            // 
            // ultraButton10
            // 
            this.ultraButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance24.Image = ((object)(resources.GetObject("appearance24.Image")));
            appearance24.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton10.Appearance = appearance24;
            this.ultraButton10.ImageSize = new System.Drawing.Size(32, 32);
            this.ultraButton10.Location = new System.Drawing.Point(368, 6);
            this.ultraButton10.Name = "ultraButton10";
            this.ultraButton10.Size = new System.Drawing.Size(115, 51);
            this.ultraButton10.TabIndex = 14;
            ultraToolTipInfo9.ToolTipText = "Save Payroll Data";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton10, ultraToolTipInfo9);
            this.ultraButton10.Click += new System.EventHandler(this.ultraButton10_Click);
            // 
            // ultraButton8
            // 
            appearance25.Image = ((object)(resources.GetObject("appearance25.Image")));
            appearance25.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton8.Appearance = appearance25;
            this.ultraButton8.ImageSize = new System.Drawing.Size(32, 32);
            this.ultraButton8.Location = new System.Drawing.Point(17, 6);
            this.ultraButton8.Name = "ultraButton8";
            this.ultraButton8.Size = new System.Drawing.Size(115, 51);
            this.ultraButton8.TabIndex = 1;
            ultraToolTipInfo10.ToolTipText = "Fetch Displayed Details From Employee Defaults";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton8, ultraToolTipInfo10);
            this.ultraButton8.Click += new System.EventHandler(this.ultraButton8_Click);
            // 
            // ultraButton9
            // 
            appearance26.Image = ((object)(resources.GetObject("appearance26.Image")));
            appearance26.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton9.Appearance = appearance26;
            this.ultraButton9.ImageSize = new System.Drawing.Size(32, 32);
            this.ultraButton9.Location = new System.Drawing.Point(134, 6);
            this.ultraButton9.Name = "ultraButton9";
            this.ultraButton9.Size = new System.Drawing.Size(115, 51);
            this.ultraButton9.TabIndex = 2;
            ultraToolTipInfo11.ToolTipText = "Update Employee Defaults From Displayed Info";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton9, ultraToolTipInfo11);
            this.ultraButton9.Click += new System.EventHandler(this.ultraButton9_Click);
            // 
            // ultraButton6
            // 
            appearance27.Image = ((object)(resources.GetObject("appearance27.Image")));
            appearance27.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton6.Appearance = appearance27;
            this.ultraButton6.ImageSize = new System.Drawing.Size(48, 48);
            this.ultraButton6.Location = new System.Drawing.Point(485, 6);
            this.ultraButton6.Name = "ultraButton6";
            this.ultraButton6.Size = new System.Drawing.Size(115, 51);
            this.ultraButton6.TabIndex = 15;
            ultraToolTipInfo12.ToolTipText = "Print Payslip";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton6, ultraToolTipInfo12);
            this.ultraButton6.Click += new System.EventHandler(this.ultraButton6_Click);
            // 
            // ultraButton7
            // 
            appearance28.Image = ((object)(resources.GetObject("appearance28.Image")));
            appearance28.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton7.Appearance = appearance28;
            this.ultraButton7.ImageSize = new System.Drawing.Size(32, 32);
            this.ultraButton7.Location = new System.Drawing.Point(251, 6);
            this.ultraButton7.Name = "ultraButton7";
            this.ultraButton7.Size = new System.Drawing.Size(115, 51);
            this.ultraButton7.TabIndex = 3;
            ultraToolTipInfo13.ToolTipText = "Delete Entry from payroll";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton7, ultraToolTipInfo13);
            this.ultraButton7.Click += new System.EventHandler(this.ultraButton7_Click);
            // 
            // ultraPanel5
            // 
            // 
            // ultraPanel5.ClientArea
            // 
            this.ultraPanel5.ClientArea.Controls.Add(this.ultraGroupBox6);
            this.ultraPanel5.ClientArea.Controls.Add(this.ultraButton21);
            this.ultraPanel5.ClientArea.Controls.Add(this.ultraButton22);
            this.ultraPanel5.ClientArea.Controls.Add(this.ultraButton23);
            this.ultraPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel5.Location = new System.Drawing.Point(205, 16);
            this.ultraPanel5.Name = "ultraPanel5";
            this.ultraPanel5.Size = new System.Drawing.Size(841, 459);
            this.ultraPanel5.TabIndex = 17;
            // 
            // ultraGroupBox6
            // 
            appearance29.BackColor = System.Drawing.Color.White;
            this.ultraGroupBox6.Appearance = appearance29;
            this.ultraGroupBox6.Controls.Add(this.ultraGroupBox11);
            this.ultraGroupBox6.Controls.Add(this.ultraGroupBox10);
            this.ultraGroupBox6.Controls.Add(this.ultraGroupBox9);
            this.ultraGroupBox6.Controls.Add(this.ultraGroupBox8);
            this.ultraGroupBox6.Controls.Add(this.ultraGroupBox7);
            this.ultraGroupBox6.Controls.Add(this.ultraLabel28);
            this.ultraGroupBox6.Controls.Add(this.ultraLabel27);
            this.ultraGroupBox6.Controls.Add(this.ultraLabel26);
            this.ultraGroupBox6.Location = new System.Drawing.Point(7, 4);
            this.ultraGroupBox6.Name = "ultraGroupBox6";
            this.ultraGroupBox6.Size = new System.Drawing.Size(785, 350);
            this.ultraGroupBox6.TabIndex = 163;
            // 
            // ultraGroupBox11
            // 
            this.ultraGroupBox11.Controls.Add(this.ultraTextEditor9);
            this.ultraGroupBox11.Controls.Add(this.ultraLabel13);
            this.ultraGroupBox11.Controls.Add(this.ultraTextEditor155);
            this.ultraGroupBox11.Controls.Add(this.ultraLabel14);
            this.ultraGroupBox11.Location = new System.Drawing.Point(532, 148);
            this.ultraGroupBox11.Name = "ultraGroupBox11";
            this.ultraGroupBox11.Size = new System.Drawing.Size(230, 96);
            this.ultraGroupBox11.TabIndex = 205;
            this.ultraGroupBox11.Text = "EMPLOYMENT";
            // 
            // ultraTextEditor9
            // 
            appearance30.FontData.BoldAsString = "True";
            appearance30.FontData.SizeInPoints = 12F;
            this.ultraTextEditor9.Appearance = appearance30;
            this.ultraTextEditor9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "occupation", true));
            this.ultraTextEditor9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor9.Location = new System.Drawing.Point(65, 56);
            this.ultraTextEditor9.Name = "ultraTextEditor9";
            this.ultraTextEditor9.Size = new System.Drawing.Size(150, 28);
            this.ultraTextEditor9.TabIndex = 188;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "Payroll";
            this.payrollBindingSource.DataSource = this.dataSet1;
            // 
            // ultraLabel13
            // 
            appearance31.TextHAlignAsString = "Right";
            appearance31.TextVAlignAsString = "Middle";
            this.ultraLabel13.Appearance = appearance31;
            this.ultraLabel13.Location = new System.Drawing.Point(5, 60);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.Size = new System.Drawing.Size(54, 22);
            this.ultraLabel13.TabIndex = 189;
            this.ultraLabel13.Text = "Occup.:";
            // 
            // ultraTextEditor155
            // 
            appearance32.FontData.BoldAsString = "True";
            appearance32.FontData.SizeInPoints = 12F;
            this.ultraTextEditor155.Appearance = appearance32;
            this.ultraTextEditor155.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "pay_id", true));
            this.ultraTextEditor155.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor155.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor155.Location = new System.Drawing.Point(65, 19);
            this.ultraTextEditor155.Name = "ultraTextEditor155";
            this.ultraTextEditor155.Size = new System.Drawing.Size(150, 28);
            this.ultraTextEditor155.TabIndex = 183;
            // 
            // ultraLabel14
            // 
            appearance33.TextHAlignAsString = "Right";
            appearance33.TextVAlignAsString = "Middle";
            this.ultraLabel14.Appearance = appearance33;
            this.ultraLabel14.Location = new System.Drawing.Point(5, 23);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.Size = new System.Drawing.Size(54, 22);
            this.ultraLabel14.TabIndex = 187;
            this.ultraLabel14.Text = "Emp.No.:";
            // 
            // ultraGroupBox10
            // 
            this.ultraGroupBox10.Controls.Add(this.ultraTextEditor7);
            this.ultraGroupBox10.Controls.Add(this.ultraLabel12);
            this.ultraGroupBox10.Controls.Add(this.ultraTextEditor157);
            this.ultraGroupBox10.Controls.Add(this.ultraTextEditor156);
            this.ultraGroupBox10.Controls.Add(this.ultraLabel15);
            this.ultraGroupBox10.Controls.Add(this.ultraLabel20);
            this.ultraGroupBox10.Location = new System.Drawing.Point(6, 68);
            this.ultraGroupBox10.Name = "ultraGroupBox10";
            this.ultraGroupBox10.Size = new System.Drawing.Size(756, 60);
            this.ultraGroupBox10.TabIndex = 204;
            this.ultraGroupBox10.Text = "EMPLOYEE";
            // 
            // ultraTextEditor7
            // 
            appearance34.FontData.BoldAsString = "True";
            appearance34.FontData.SizeInPoints = 12F;
            this.ultraTextEditor7.Appearance = appearance34;
            this.ultraTextEditor7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "identity_no", true));
            this.ultraTextEditor7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor7.Location = new System.Drawing.Point(604, 19);
            this.ultraTextEditor7.Name = "ultraTextEditor7";
            this.ultraTextEditor7.Size = new System.Drawing.Size(137, 28);
            this.ultraTextEditor7.TabIndex = 189;
            // 
            // ultraLabel12
            // 
            appearance35.TextHAlignAsString = "Right";
            appearance35.TextVAlignAsString = "Middle";
            this.ultraLabel12.Appearance = appearance35;
            this.ultraLabel12.Location = new System.Drawing.Point(555, 23);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(43, 22);
            this.ultraLabel12.TabIndex = 190;
            this.ultraLabel12.Text = "ID.No.:";
            // 
            // ultraTextEditor157
            // 
            appearance36.FontData.BoldAsString = "True";
            appearance36.FontData.SizeInPoints = 14F;
            this.ultraTextEditor157.Appearance = appearance36;
            this.ultraTextEditor157.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "firstname", true));
            this.ultraTextEditor157.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor157.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor157.Location = new System.Drawing.Point(357, 19);
            this.ultraTextEditor157.Name = "ultraTextEditor157";
            this.ultraTextEditor157.Size = new System.Drawing.Size(173, 31);
            this.ultraTextEditor157.TabIndex = 185;
            // 
            // ultraTextEditor156
            // 
            appearance37.FontData.BoldAsString = "True";
            appearance37.FontData.SizeInPoints = 14F;
            this.ultraTextEditor156.Appearance = appearance37;
            this.ultraTextEditor156.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "lastname", true));
            this.ultraTextEditor156.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraTextEditor156.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor156.Location = new System.Drawing.Point(72, 19);
            this.ultraTextEditor156.Name = "ultraTextEditor156";
            this.ultraTextEditor156.Size = new System.Drawing.Size(209, 31);
            this.ultraTextEditor156.TabIndex = 184;
            // 
            // ultraLabel15
            // 
            appearance38.TextHAlignAsString = "Right";
            appearance38.TextVAlignAsString = "Middle";
            this.ultraLabel15.Appearance = appearance38;
            this.ultraLabel15.Location = new System.Drawing.Point(6, 23);
            this.ultraLabel15.Name = "ultraLabel15";
            this.ultraLabel15.Size = new System.Drawing.Size(60, 22);
            this.ultraLabel15.TabIndex = 186;
            this.ultraLabel15.Text = "Surname:";
            // 
            // ultraLabel20
            // 
            appearance39.TextHAlignAsString = "Right";
            appearance39.TextVAlignAsString = "Middle";
            this.ultraLabel20.Appearance = appearance39;
            this.ultraLabel20.Location = new System.Drawing.Point(287, 23);
            this.ultraLabel20.Name = "ultraLabel20";
            this.ultraLabel20.Size = new System.Drawing.Size(68, 22);
            this.ultraLabel20.TabIndex = 188;
            this.ultraLabel20.Text = "First Name:";
            // 
            // ultraGroupBox9
            // 
            this.ultraGroupBox9.Controls.Add(this.ultraMaskedEdit2);
            this.ultraGroupBox9.Controls.Add(this.ultraLabel11);
            this.ultraGroupBox9.Controls.Add(this.ultraLabel16);
            this.ultraGroupBox9.Controls.Add(this.ultraMaskedEdit3);
            this.ultraGroupBox9.Controls.Add(this.ultraTextEditor8);
            this.ultraGroupBox9.Controls.Add(this.ultraMaskedEdit1);
            this.ultraGroupBox9.Location = new System.Drawing.Point(6, 134);
            this.ultraGroupBox9.Name = "ultraGroupBox9";
            this.ultraGroupBox9.Size = new System.Drawing.Size(257, 210);
            this.ultraGroupBox9.TabIndex = 203;
            this.ultraGroupBox9.Text = "EARNINGS";
            // 
            // ultraMaskedEdit2
            // 
            appearance40.FontData.BoldAsString = "True";
            appearance40.FontData.SizeInPoints = 16F;
            appearance40.TextHAlignAsString = "Right";
            appearance40.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit2.Appearance = appearance40;
            this.ultraMaskedEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "other_earnings1_value", true));
            this.ultraMaskedEdit2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit2.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit2.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit2.Location = new System.Drawing.Point(125, 54);
            this.ultraMaskedEdit2.Name = "ultraMaskedEdit2";
            this.ultraMaskedEdit2.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit2.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit2.TabIndex = 193;
            // 
            // ultraLabel11
            // 
            appearance41.TextHAlignAsString = "Right";
            appearance41.TextVAlignAsString = "Middle";
            this.ultraLabel11.Appearance = appearance41;
            this.ultraLabel11.Location = new System.Drawing.Point(23, 103);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(91, 23);
            this.ultraLabel11.TabIndex = 165;
            this.ultraLabel11.Text = "Gross Earnings:";
            // 
            // ultraLabel16
            // 
            appearance42.TextHAlignAsString = "Right";
            appearance42.TextVAlignAsString = "Middle";
            this.ultraLabel16.Appearance = appearance42;
            this.ultraLabel16.Location = new System.Drawing.Point(39, 21);
            this.ultraLabel16.Name = "ultraLabel16";
            this.ultraLabel16.Size = new System.Drawing.Size(75, 22);
            this.ultraLabel16.TabIndex = 168;
            this.ultraLabel16.Text = "Basic Salary:";
            // 
            // ultraMaskedEdit3
            // 
            appearance43.FontData.BoldAsString = "True";
            appearance43.FontData.SizeInPoints = 16F;
            appearance43.TextHAlignAsString = "Right";
            appearance43.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit3.Appearance = appearance43;
            this.ultraMaskedEdit3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "gross_pay", true));
            this.ultraMaskedEdit3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit3.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit3.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit3.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit3.Location = new System.Drawing.Point(125, 94);
            this.ultraMaskedEdit3.Name = "ultraMaskedEdit3";
            this.ultraMaskedEdit3.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit3.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit3.TabIndex = 194;
            // 
            // ultraTextEditor8
            // 
            appearance44.TextHAlignAsString = "Right";
            this.ultraTextEditor8.Appearance = appearance44;
            this.ultraTextEditor8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "other_earnings1_descr", true));
            this.ultraTextEditor8.Location = new System.Drawing.Point(14, 60);
            this.ultraTextEditor8.Name = "ultraTextEditor8";
            this.ultraTextEditor8.Size = new System.Drawing.Size(100, 21);
            this.ultraTextEditor8.TabIndex = 169;
            this.ultraTextEditor8.Text = "Other Earnings";
            // 
            // ultraMaskedEdit1
            // 
            appearance45.FontData.BoldAsString = "True";
            appearance45.FontData.SizeInPoints = 16F;
            appearance45.TextHAlignAsString = "Right";
            appearance45.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit1.Appearance = appearance45;
            this.ultraMaskedEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "basic_salary", true));
            this.ultraMaskedEdit1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit1.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit1.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit1.Location = new System.Drawing.Point(125, 16);
            this.ultraMaskedEdit1.Name = "ultraMaskedEdit1";
            this.ultraMaskedEdit1.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit1.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit1.TabIndex = 192;
            // 
            // ultraGroupBox8
            // 
            this.ultraGroupBox8.Controls.Add(this.ultraMaskedEdit8);
            this.ultraGroupBox8.Controls.Add(this.ultraLabel10);
            this.ultraGroupBox8.Controls.Add(this.ultraMaskedEdit9);
            this.ultraGroupBox8.Controls.Add(this.ultraLabel17);
            this.ultraGroupBox8.Controls.Add(this.ultraLabel18);
            this.ultraGroupBox8.Controls.Add(this.ultraMaskedEdit7);
            this.ultraGroupBox8.Controls.Add(this.ultraLabel19);
            this.ultraGroupBox8.Controls.Add(this.ultraMaskedEdit6);
            this.ultraGroupBox8.Controls.Add(this.ultraTextEditor10);
            this.ultraGroupBox8.Controls.Add(this.ultraMaskedEdit5);
            this.ultraGroupBox8.Location = new System.Drawing.Point(269, 134);
            this.ultraGroupBox8.Name = "ultraGroupBox8";
            this.ultraGroupBox8.Size = new System.Drawing.Size(257, 210);
            this.ultraGroupBox8.TabIndex = 202;
            this.ultraGroupBox8.Text = "DEDUCTIONS";
            // 
            // ultraMaskedEdit8
            // 
            appearance46.FontData.BoldAsString = "True";
            appearance46.FontData.SizeInPoints = 16F;
            appearance46.TextHAlignAsString = "Right";
            appearance46.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit8.Appearance = appearance46;
            this.ultraMaskedEdit8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "other_deduction1_value", true));
            this.ultraMaskedEdit8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit8.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit8.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit8.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit8.Location = new System.Drawing.Point(116, 130);
            this.ultraMaskedEdit8.Name = "ultraMaskedEdit8";
            this.ultraMaskedEdit8.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit8.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit8.TabIndex = 199;
            // 
            // ultraLabel10
            // 
            appearance47.TextHAlignAsString = "Right";
            appearance47.TextVAlignAsString = "Middle";
            this.ultraLabel10.Appearance = appearance47;
            this.ultraLabel10.Location = new System.Drawing.Point(5, 171);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel10.TabIndex = 166;
            this.ultraLabel10.Text = "Gross Deductions:";
            // 
            // ultraMaskedEdit9
            // 
            appearance48.FontData.BoldAsString = "True";
            appearance48.FontData.SizeInPoints = 16F;
            appearance48.TextHAlignAsString = "Right";
            appearance48.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit9.Appearance = appearance48;
            this.ultraMaskedEdit9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "total_deduction", true));
            this.ultraMaskedEdit9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit9.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit9.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit9.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit9.Location = new System.Drawing.Point(116, 166);
            this.ultraMaskedEdit9.Name = "ultraMaskedEdit9";
            this.ultraMaskedEdit9.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit9.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit9.TabIndex = 200;
            // 
            // ultraLabel17
            // 
            appearance49.TextHAlignAsString = "Right";
            appearance49.TextVAlignAsString = "Middle";
            this.ultraLabel17.Appearance = appearance49;
            this.ultraLabel17.Location = new System.Drawing.Point(61, 27);
            this.ultraLabel17.Name = "ultraLabel17";
            this.ultraLabel17.Size = new System.Drawing.Size(44, 22);
            this.ultraLabel17.TabIndex = 170;
            this.ultraLabel17.Text = "PAYE:";
            // 
            // ultraLabel18
            // 
            appearance50.TextHAlignAsString = "Right";
            appearance50.TextVAlignAsString = "Middle";
            this.ultraLabel18.Appearance = appearance50;
            this.ultraLabel18.Location = new System.Drawing.Point(70, 63);
            this.ultraLabel18.Name = "ultraLabel18";
            this.ultraLabel18.Size = new System.Drawing.Size(35, 23);
            this.ultraLabel18.TabIndex = 171;
            this.ultraLabel18.Text = "UIF:";
            // 
            // ultraMaskedEdit7
            // 
            appearance51.FontData.BoldAsString = "True";
            appearance51.FontData.SizeInPoints = 16F;
            appearance51.TextHAlignAsString = "Right";
            appearance51.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit7.Appearance = appearance51;
            this.ultraMaskedEdit7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "providend", true));
            this.ultraMaskedEdit7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit7.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit7.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit7.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit7.Location = new System.Drawing.Point(116, 94);
            this.ultraMaskedEdit7.Name = "ultraMaskedEdit7";
            this.ultraMaskedEdit7.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit7.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit7.TabIndex = 198;
            // 
            // ultraLabel19
            // 
            appearance52.TextHAlignAsString = "Right";
            appearance52.TextVAlignAsString = "Middle";
            this.ultraLabel19.Appearance = appearance52;
            this.ultraLabel19.Location = new System.Drawing.Point(19, 99);
            this.ultraLabel19.Name = "ultraLabel19";
            this.ultraLabel19.Size = new System.Drawing.Size(86, 23);
            this.ultraLabel19.TabIndex = 172;
            this.ultraLabel19.Text = "Pension Fund:";
            // 
            // ultraMaskedEdit6
            // 
            appearance53.FontData.BoldAsString = "True";
            appearance53.FontData.SizeInPoints = 16F;
            appearance53.TextHAlignAsString = "Right";
            appearance53.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit6.Appearance = appearance53;
            this.ultraMaskedEdit6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "uif", true));
            this.ultraMaskedEdit6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit6.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit6.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit6.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit6.Location = new System.Drawing.Point(116, 58);
            this.ultraMaskedEdit6.Name = "ultraMaskedEdit6";
            this.ultraMaskedEdit6.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit6.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit6.TabIndex = 197;
            // 
            // ultraTextEditor10
            // 
            appearance54.TextHAlignAsString = "Right";
            this.ultraTextEditor10.Appearance = appearance54;
            this.ultraTextEditor10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "other_deduction1_descr", true));
            this.ultraTextEditor10.Location = new System.Drawing.Point(5, 136);
            this.ultraTextEditor10.Name = "ultraTextEditor10";
            this.ultraTextEditor10.Size = new System.Drawing.Size(100, 21);
            this.ultraTextEditor10.TabIndex = 182;
            this.ultraTextEditor10.Text = "Other Deductions";
            // 
            // ultraMaskedEdit5
            // 
            appearance55.FontData.BoldAsString = "True";
            appearance55.FontData.SizeInPoints = 16F;
            appearance55.TextHAlignAsString = "Right";
            appearance55.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit5.Appearance = appearance55;
            this.ultraMaskedEdit5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "paye", true));
            this.ultraMaskedEdit5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit5.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit5.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit5.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit5.Location = new System.Drawing.Point(116, 22);
            this.ultraMaskedEdit5.Name = "ultraMaskedEdit5";
            this.ultraMaskedEdit5.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit5.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit5.TabIndex = 196;
            // 
            // ultraGroupBox7
            // 
            this.ultraGroupBox7.Controls.Add(this.ultraMaskedEdit4);
            this.ultraGroupBox7.Controls.Add(this.ultraLabel9);
            this.ultraGroupBox7.Location = new System.Drawing.Point(532, 287);
            this.ultraGroupBox7.Name = "ultraGroupBox7";
            this.ultraGroupBox7.Size = new System.Drawing.Size(230, 55);
            this.ultraGroupBox7.TabIndex = 201;
            // 
            // ultraMaskedEdit4
            // 
            appearance56.FontData.BoldAsString = "True";
            appearance56.FontData.SizeInPoints = 16F;
            appearance56.TextHAlignAsString = "Right";
            appearance56.TextVAlignAsString = "Middle";
            this.ultraMaskedEdit4.Appearance = appearance56;
            this.ultraMaskedEdit4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "net_pay", true));
            this.ultraMaskedEdit4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.ultraMaskedEdit4.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMaskedEdit4.FormatString = "nnnnnnn.nn";
            this.ultraMaskedEdit4.InputMask = "nnnnnnn.nn";
            this.ultraMaskedEdit4.Location = new System.Drawing.Point(88, 11);
            this.ultraMaskedEdit4.Name = "ultraMaskedEdit4";
            this.ultraMaskedEdit4.NonAutoSizeHeight = 20;
            this.ultraMaskedEdit4.Size = new System.Drawing.Size(127, 32);
            this.ultraMaskedEdit4.TabIndex = 195;
            // 
            // ultraLabel9
            // 
            appearance57.FontData.BoldAsString = "True";
            appearance57.TextHAlignAsString = "Right";
            appearance57.TextVAlignAsString = "Middle";
            this.ultraLabel9.Appearance = appearance57;
            this.ultraLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel9.Location = new System.Drawing.Point(11, 16);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(66, 23);
            this.ultraLabel9.TabIndex = 167;
            this.ultraLabel9.Text = "NET PAY:";
            // 
            // ultraLabel28
            // 
            appearance58.TextHAlignAsString = "Center";
            appearance58.TextVAlignAsString = "Top";
            this.ultraLabel28.Appearance = appearance58;
            this.ultraLabel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel28.Location = new System.Drawing.Point(3, 44);
            this.ultraLabel28.Name = "ultraLabel28";
            this.ultraLabel28.Size = new System.Drawing.Size(779, 17);
            this.ultraLabel28.TabIndex = 191;
            this.ultraLabel28.Text = "ultraLabel28";
            // 
            // ultraLabel27
            // 
            appearance59.TextHAlignAsString = "Center";
            appearance59.TextVAlignAsString = "Top";
            this.ultraLabel27.Appearance = appearance59;
            this.ultraLabel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel27.Location = new System.Drawing.Point(3, 27);
            this.ultraLabel27.Name = "ultraLabel27";
            this.ultraLabel27.Size = new System.Drawing.Size(779, 17);
            this.ultraLabel27.TabIndex = 190;
            this.ultraLabel27.Text = "ultraLabel27";
            // 
            // ultraLabel26
            // 
            appearance60.TextHAlignAsString = "Center";
            appearance60.TextVAlignAsString = "Top";
            this.ultraLabel26.Appearance = appearance60;
            this.ultraLabel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel26.Location = new System.Drawing.Point(3, 3);
            this.ultraLabel26.Name = "ultraLabel26";
            this.ultraLabel26.Size = new System.Drawing.Size(779, 24);
            this.ultraLabel26.TabIndex = 189;
            this.ultraLabel26.Text = "ultraLabel26";
            // 
            // ultraButton21
            // 
            this.ultraButton21.Location = new System.Drawing.Point(357, 360);
            this.ultraButton21.Name = "ultraButton21";
            this.ultraButton21.Size = new System.Drawing.Size(143, 23);
            this.ultraButton21.TabIndex = 99;
            this.ultraButton21.Text = "UIF";
            this.ultraButton21.Click += new System.EventHandler(this.ultraButton21_Click);
            // 
            // ultraButton22
            // 
            this.ultraButton22.Location = new System.Drawing.Point(184, 360);
            this.ultraButton22.Name = "ultraButton22";
            this.ultraButton22.Size = new System.Drawing.Size(143, 23);
            this.ultraButton22.TabIndex = 98;
            this.ultraButton22.Text = "SARS PAYE Tables";
            this.ultraButton22.Click += new System.EventHandler(this.ultraButton22_Click);
            // 
            // ultraButton23
            // 
            this.ultraButton23.Location = new System.Drawing.Point(527, 360);
            this.ultraButton23.Name = "ultraButton23";
            this.ultraButton23.Size = new System.Drawing.Size(143, 23);
            this.ultraButton23.TabIndex = 97;
            this.ultraButton23.Text = "Recalc Net Pay";
            this.ultraButton23.Click += new System.EventHandler(this.ultraButton23_Click);
            // 
            // ultraSplitter3
            // 
            this.ultraSplitter3.Location = new System.Drawing.Point(199, 16);
            this.ultraSplitter3.Name = "ultraSplitter3";
            this.ultraSplitter3.RestoreExtent = 0;
            this.ultraSplitter3.Size = new System.Drawing.Size(6, 459);
            this.ultraSplitter3.TabIndex = 16;
            // 
            // ultraPanel4
            // 
            // 
            // ultraPanel4.ClientArea
            // 
            this.ultraPanel4.ClientArea.Controls.Add(this.ultraSplitter5);
            this.ultraPanel4.ClientArea.Controls.Add(this.ultraPanel8);
            this.ultraPanel4.ClientArea.Controls.Add(this.ultraPanel7);
            this.ultraPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraPanel4.Location = new System.Drawing.Point(3, 16);
            this.ultraPanel4.Name = "ultraPanel4";
            this.ultraPanel4.Size = new System.Drawing.Size(196, 459);
            this.ultraPanel4.TabIndex = 5;
            // 
            // ultraSplitter5
            // 
            this.ultraSplitter5.BackColor = System.Drawing.Color.MintCream;
            this.ultraSplitter5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraSplitter5.Location = new System.Drawing.Point(0, 147);
            this.ultraSplitter5.Name = "ultraSplitter5";
            this.ultraSplitter5.RestoreExtent = 306;
            this.ultraSplitter5.Size = new System.Drawing.Size(196, 6);
            this.ultraSplitter5.TabIndex = 2;
            // 
            // ultraPanel8
            // 
            // 
            // ultraPanel8.ClientArea
            // 
            this.ultraPanel8.ClientArea.Controls.Add(this.ultraButton24);
            this.ultraPanel8.ClientArea.Controls.Add(this.ultraGrid2);
            this.ultraPanel8.ClientArea.Controls.Add(this.ultraLabel23);
            this.ultraPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraPanel8.Location = new System.Drawing.Point(0, 153);
            this.ultraPanel8.Name = "ultraPanel8";
            this.ultraPanel8.Size = new System.Drawing.Size(196, 306);
            this.ultraPanel8.TabIndex = 1;
            // 
            // ultraButton24
            // 
            appearance61.Image = ((object)(resources.GetObject("appearance61.Image")));
            appearance61.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton24.Appearance = appearance61;
            this.ultraButton24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraButton24.ImageSize = new System.Drawing.Size(80, 40);
            this.ultraButton24.Location = new System.Drawing.Point(0, 237);
            this.ultraButton24.Name = "ultraButton24";
            this.ultraButton24.Size = new System.Drawing.Size(196, 69);
            this.ultraButton24.TabIndex = 35;
            ultraToolTipInfo14.ToolTipText = "Lock Down This Payroll";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton24, ultraToolTipInfo14);
            this.ultraButton24.Click += new System.EventHandler(this.ultraButton24_Click);
            // 
            // ultraGrid2
            // 
            this.ultraGrid2.DataSource = this.payrollBindingSource;
            appearance62.BackColor = System.Drawing.SystemColors.Window;
            appearance62.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid2.DisplayLayout.Appearance = appearance62;
            ultraGridColumn178.Header.VisiblePosition = 0;
            ultraGridColumn178.Hidden = true;
            ultraGridColumn179.Header.Caption = "Surname";
            ultraGridColumn179.Header.VisiblePosition = 1;
            ultraGridColumn179.Width = 120;
            ultraGridColumn180.Header.Caption = "First Name";
            ultraGridColumn180.Header.VisiblePosition = 2;
            ultraGridColumn180.Width = 70;
            ultraGridColumn181.Header.Caption = "ID Number";
            ultraGridColumn181.Header.VisiblePosition = 3;
            ultraGridColumn181.Hidden = true;
            ultraGridColumn182.Header.Caption = "Empl.No.";
            ultraGridColumn182.Header.VisiblePosition = 4;
            ultraGridColumn182.Hidden = true;
            ultraGridColumn183.Header.Caption = "Occupation";
            ultraGridColumn183.Header.VisiblePosition = 5;
            ultraGridColumn183.Hidden = true;
            ultraGridColumn183.Width = 102;
            ultraGridColumn184.Header.VisiblePosition = 19;
            ultraGridColumn184.Hidden = true;
            ultraGridColumn185.Header.VisiblePosition = 6;
            ultraGridColumn185.Hidden = true;
            ultraGridColumn186.Header.Caption = "Act/Dormt";
            ultraGridColumn186.Header.VisiblePosition = 20;
            ultraGridColumn186.Hidden = true;
            ultraGridColumn186.Width = 70;
            ultraGridColumn187.Header.VisiblePosition = 7;
            ultraGridColumn187.Hidden = true;
            ultraGridColumn188.Header.VisiblePosition = 8;
            ultraGridColumn188.Hidden = true;
            ultraGridColumn189.Header.VisiblePosition = 9;
            ultraGridColumn189.Hidden = true;
            ultraGridColumn190.Header.VisiblePosition = 10;
            ultraGridColumn190.Hidden = true;
            ultraGridColumn191.Header.VisiblePosition = 11;
            ultraGridColumn191.Hidden = true;
            ultraGridColumn192.Header.VisiblePosition = 12;
            ultraGridColumn192.Hidden = true;
            ultraGridColumn193.Header.VisiblePosition = 13;
            ultraGridColumn193.Hidden = true;
            ultraGridColumn194.Header.VisiblePosition = 14;
            ultraGridColumn194.Hidden = true;
            ultraGridColumn195.Header.VisiblePosition = 15;
            ultraGridColumn195.Hidden = true;
            ultraGridColumn196.Header.VisiblePosition = 16;
            ultraGridColumn196.Hidden = true;
            ultraGridColumn197.Header.VisiblePosition = 17;
            ultraGridColumn197.Hidden = true;
            ultraGridColumn198.Header.VisiblePosition = 18;
            ultraGridColumn198.Hidden = true;
            ultraGridColumn199.Header.VisiblePosition = 21;
            ultraGridColumn199.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180,
            ultraGridColumn181,
            ultraGridColumn182,
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185,
            ultraGridColumn186,
            ultraGridColumn187,
            ultraGridColumn188,
            ultraGridColumn189,
            ultraGridColumn190,
            ultraGridColumn191,
            ultraGridColumn192,
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196,
            ultraGridColumn197,
            ultraGridColumn198,
            ultraGridColumn199});
            this.ultraGrid2.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGrid2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance63.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance63.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.GroupByBox.Appearance = appearance63;
            appearance64.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid2.DisplayLayout.GroupByBox.BandLabelAppearance = appearance64;
            this.ultraGrid2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid2.DisplayLayout.GroupByBox.Hidden = true;
            appearance65.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance65.BackColor2 = System.Drawing.SystemColors.Control;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance65.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid2.DisplayLayout.GroupByBox.PromptAppearance = appearance65;
            this.ultraGrid2.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid2.DisplayLayout.MaxRowScrollRegions = 1;
            appearance66.BackColor = System.Drawing.SystemColors.Window;
            appearance66.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid2.DisplayLayout.Override.ActiveCellAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.Highlight;
            appearance67.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid2.DisplayLayout.Override.ActiveRowAppearance = appearance67;
            this.ultraGrid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance68.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.Override.CardAreaAppearance = appearance68;
            appearance69.BorderColor = System.Drawing.Color.Silver;
            appearance69.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid2.DisplayLayout.Override.CellAppearance = appearance69;
            this.ultraGrid2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid2.DisplayLayout.Override.CellPadding = 0;
            appearance70.BackColor = System.Drawing.SystemColors.Control;
            appearance70.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance70.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance70.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid2.DisplayLayout.Override.GroupByRowAppearance = appearance70;
            appearance71.TextHAlignAsString = "Left";
            this.ultraGrid2.DisplayLayout.Override.HeaderAppearance = appearance71;
            this.ultraGrid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance72.BackColor = System.Drawing.SystemColors.Window;
            appearance72.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid2.DisplayLayout.Override.RowAppearance = appearance72;
            this.ultraGrid2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance73.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid2.DisplayLayout.Override.TemplateAddRowAppearance = appearance73;
            this.ultraGrid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid2.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ultraGrid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid2.Location = new System.Drawing.Point(0, 14);
            this.ultraGrid2.Name = "ultraGrid2";
            this.ultraGrid2.Size = new System.Drawing.Size(196, 216);
            this.ultraGrid2.TabIndex = 34;
            this.ultraGrid2.Text = "ultraGrid2";
            // 
            // ultraLabel23
            // 
            this.ultraLabel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel23.Location = new System.Drawing.Point(0, 0);
            this.ultraLabel23.Name = "ultraLabel23";
            this.ultraLabel23.Size = new System.Drawing.Size(196, 14);
            this.ultraLabel23.TabIndex = 33;
            this.ultraLabel23.Text = "Employees Active For Payroll:";
            // 
            // ultraPanel7
            // 
            // 
            // ultraPanel7.ClientArea
            // 
            this.ultraPanel7.ClientArea.Controls.Add(this.ultraDateTimeEditor2);
            this.ultraPanel7.ClientArea.Controls.Add(this.ultraComboEditor2);
            this.ultraPanel7.ClientArea.Controls.Add(this.ultraButton13);
            this.ultraPanel7.ClientArea.Controls.Add(this.ultraLabel22);
            this.ultraPanel7.ClientArea.Controls.Add(this.ultraLabel21);
            this.ultraPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel7.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel7.Name = "ultraPanel7";
            this.ultraPanel7.Size = new System.Drawing.Size(196, 147);
            this.ultraPanel7.TabIndex = 0;
            // 
            // ultraDateTimeEditor2
            // 
            this.ultraDateTimeEditor2.DateTime = new System.DateTime(2017, 3, 21, 0, 0, 0, 0);
            this.ultraDateTimeEditor2.Location = new System.Drawing.Point(69, 41);
            this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
            this.ultraDateTimeEditor2.Size = new System.Drawing.Size(107, 21);
            this.ultraDateTimeEditor2.TabIndex = 35;
            this.ultraDateTimeEditor2.Value = new System.DateTime(2017, 3, 21, 0, 0, 0, 0);
            // 
            // ultraComboEditor2
            // 
            valueListItem3.DataValue = "January";
            valueListItem4.DataValue = "February";
            valueListItem5.DataValue = "March";
            valueListItem6.DataValue = "April";
            valueListItem7.DataValue = "May";
            valueListItem8.DataValue = "June";
            valueListItem9.DataValue = "July";
            valueListItem10.DataValue = "August";
            valueListItem11.DataValue = "September";
            valueListItem12.DataValue = "October";
            valueListItem13.DataValue = "November";
            valueListItem14.DataValue = "December";
            valueListItem15.DataValue = "Bonus";
            this.ultraComboEditor2.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4,
            valueListItem5,
            valueListItem6,
            valueListItem7,
            valueListItem8,
            valueListItem9,
            valueListItem10,
            valueListItem11,
            valueListItem12,
            valueListItem13,
            valueListItem14,
            valueListItem15});
            this.ultraComboEditor2.Location = new System.Drawing.Point(69, 11);
            this.ultraComboEditor2.Name = "ultraComboEditor2";
            this.ultraComboEditor2.Size = new System.Drawing.Size(107, 21);
            this.ultraComboEditor2.TabIndex = 34;
            // 
            // ultraButton13
            // 
            appearance74.Image = ((object)(resources.GetObject("appearance74.Image")));
            appearance74.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton13.Appearance = appearance74;
            this.ultraButton13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraButton13.ImageSize = new System.Drawing.Size(80, 40);
            this.ultraButton13.Location = new System.Drawing.Point(0, 78);
            this.ultraButton13.Name = "ultraButton13";
            this.ultraButton13.Size = new System.Drawing.Size(196, 69);
            this.ultraButton13.TabIndex = 33;
            ultraToolTipInfo15.ToolTipText = "Start FRESH Payroll";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton13, ultraToolTipInfo15);
            this.ultraButton13.Click += new System.EventHandler(this.ultraButton13_Click);
            // 
            // ultraLabel22
            // 
            this.ultraLabel22.Location = new System.Drawing.Point(14, 44);
            this.ultraLabel22.Name = "ultraLabel22";
            this.ultraLabel22.Size = new System.Drawing.Size(62, 14);
            this.ultraLabel22.TabIndex = 31;
            this.ultraLabel22.Text = "Pay date:";
            // 
            // ultraLabel21
            // 
            this.ultraLabel21.Location = new System.Drawing.Point(14, 14);
            this.ultraLabel21.Name = "ultraLabel21";
            this.ultraLabel21.Size = new System.Drawing.Size(62, 14);
            this.ultraLabel21.TabIndex = 30;
            this.ultraLabel21.Text = "Month of:";
            // 
            // ultraTabPageControl3
            // 
            this.ultraTabPageControl3.Controls.Add(this.ultraGroupBox3);
            this.ultraTabPageControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl3.Name = "ultraTabPageControl3";
            this.ultraTabPageControl3.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.ultraTilePanel1);
            this.ultraGroupBox3.Location = new System.Drawing.Point(4, 4);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(1049, 478);
            this.ultraGroupBox3.TabIndex = 3;
            this.ultraGroupBox3.Text = "Page 3 of 4 - Payroll Reports";
            // 
            // ultraTilePanel1
            // 
            this.ultraTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTilePanel1.LargeTileOrientation = Infragistics.Win.Misc.TileOrientation.Vertical;
            this.ultraTilePanel1.LargeTilePosition = Infragistics.Win.Misc.LargeTilePosition.Left;
            this.ultraTilePanel1.Location = new System.Drawing.Point(3, 16);
            this.ultraTilePanel1.Name = "ultraTilePanel1";
            this.ultraTilePanel1.NormalModeDimensions = new System.Drawing.Size(2, 2);
            this.ultraTilePanel1.Size = new System.Drawing.Size(1043, 459);
            this.ultraTilePanel1.TabIndex = 0;
            this.ultraTilePanel1.Tiles.Add(this.ultraTile1);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile2);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile3);
            this.ultraTilePanel1.Tiles.Add(this.ultraTile8);
            // 
            // ultraTile1
            // 
            this.ultraTile1.Caption = "Payslips";
            this.ultraTile1.Control = this.ultraButton14;
            this.ultraTile1.Controls.Add(this.ultraButton14);
            this.ultraTile1.IndexInLargeTileCollection = 0;
            this.ultraTile1.Name = "ultraTile1";
            this.ultraTile1.PositionInNormalMode = new System.Drawing.Point(0, 0);
            this.ultraTile1.State = Infragistics.Win.Misc.TileState.Large;
            this.ultraTile1.TabIndex = 0;
            // 
            // ultraButton14
            // 
            appearance75.Image = ((object)(resources.GetObject("appearance75.Image")));
            appearance75.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance75.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton14.Appearance = appearance75;
            this.ultraButton14.ImageSize = new System.Drawing.Size(512, 384);
            this.ultraButton14.Location = new System.Drawing.Point(0, 18);
            this.ultraButton14.Name = "ultraButton14";
            this.ultraButton14.Size = new System.Drawing.Size(823, 421);
            this.ultraButton14.TabIndex = 0;
            ultraToolTipInfo16.ToolTipText = "Print Payslips for Payroll Employees";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton14, ultraToolTipInfo16);
            this.ultraButton14.Click += new System.EventHandler(this.ultraButton14_Click);
            // 
            // ultraTile2
            // 
            this.ultraTile2.Caption = "Salary Schedule";
            this.ultraTile2.Control = this.ultraButton15;
            this.ultraTile2.Controls.Add(this.ultraButton15);
            this.ultraTile2.Name = "ultraTile2";
            this.ultraTile2.PositionInNormalMode = new System.Drawing.Point(1, 0);
            this.ultraTile2.TabIndex = 1;
            // 
            // ultraButton15
            // 
            appearance76.Image = ((object)(resources.GetObject("appearance76.Image")));
            appearance76.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance76.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton15.Appearance = appearance76;
            this.ultraButton15.ImageSize = new System.Drawing.Size(128, 128);
            this.ultraButton15.Location = new System.Drawing.Point(0, 18);
            this.ultraButton15.Name = "ultraButton15";
            this.ultraButton15.Size = new System.Drawing.Size(180, 121);
            this.ultraButton15.TabIndex = 1;
            ultraToolTipInfo17.ToolTipText = "Print Salary Schedule";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton15, ultraToolTipInfo17);
            this.ultraButton15.Click += new System.EventHandler(this.ultraButton15_Click);
            // 
            // ultraTile3
            // 
            this.ultraTile3.Caption = "Payroll Summary";
            this.ultraTile3.Control = this.ultraButton16;
            this.ultraTile3.Controls.Add(this.ultraButton16);
            this.ultraTile3.Name = "ultraTile3";
            this.ultraTile3.PositionInNormalMode = new System.Drawing.Point(0, 1);
            this.ultraTile3.TabIndex = 2;
            // 
            // ultraButton16
            // 
            appearance77.Image = ((object)(resources.GetObject("appearance77.Image")));
            appearance77.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance77.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton16.Appearance = appearance77;
            this.ultraButton16.ImageSize = new System.Drawing.Size(132, 108);
            this.ultraButton16.Location = new System.Drawing.Point(0, 18);
            this.ultraButton16.Name = "ultraButton16";
            this.ultraButton16.Size = new System.Drawing.Size(180, 121);
            this.ultraButton16.TabIndex = 2;
            ultraToolTipInfo18.ToolTipText = "Print Payroll Summary";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton16, ultraToolTipInfo18);
            this.ultraButton16.Click += new System.EventHandler(this.ultraButton16_Click);
            // 
            // ultraTile8
            // 
            this.ultraTile8.Caption = "Close Off Payroll";
            this.ultraTile8.Control = this.ultraButton25;
            this.ultraTile8.Controls.Add(this.ultraButton25);
            this.ultraTile8.Name = "ultraTile8";
            this.ultraTile8.TabIndex = 3;
            // 
            // ultraButton25
            // 
            appearance78.Image = ((object)(resources.GetObject("appearance78.Image")));
            appearance78.ImageHAlign = Infragistics.Win.HAlign.Center;
            this.ultraButton25.Appearance = appearance78;
            this.ultraButton25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraButton25.ImageSize = new System.Drawing.Size(80, 40);
            this.ultraButton25.Location = new System.Drawing.Point(0, 18);
            this.ultraButton25.Name = "ultraButton25";
            this.ultraButton25.Size = new System.Drawing.Size(180, 121);
            this.ultraButton25.TabIndex = 36;
            ultraToolTipInfo19.ToolTipText = "Slot Payroll into Annual Totals";
            this.ultraToolTipManager1.SetUltraToolTip(this.ultraButton25, ultraToolTipInfo19);
            this.ultraButton25.Click += new System.EventHandler(this.ultraButton24_Click);
            // 
            // ultraTabPageControl4
            // 
            this.ultraTabPageControl4.Controls.Add(this.ultraGroupBox4);
            this.ultraTabPageControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl4.Name = "ultraTabPageControl4";
            this.ultraTabPageControl4.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraGroupBox4
            // 
            this.ultraGroupBox4.Controls.Add(this.ultraTilePanel2);
            this.ultraGroupBox4.Location = new System.Drawing.Point(4, 4);
            this.ultraGroupBox4.Name = "ultraGroupBox4";
            this.ultraGroupBox4.Size = new System.Drawing.Size(1049, 478);
            this.ultraGroupBox4.TabIndex = 4;
            this.ultraGroupBox4.Text = "Page 4 of 4 - Statutory and Other Reports";
            // 
            // ultraTilePanel2
            // 
            this.ultraTilePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTilePanel2.Location = new System.Drawing.Point(3, 16);
            this.ultraTilePanel2.Name = "ultraTilePanel2";
            this.ultraTilePanel2.NormalModeDimensions = new System.Drawing.Size(2, 2);
            this.ultraTilePanel2.Size = new System.Drawing.Size(1043, 459);
            this.ultraTilePanel2.TabIndex = 0;
            this.ultraTilePanel2.Tiles.Add(this.ultraTile4);
            this.ultraTilePanel2.Tiles.Add(this.ultraTile5);
            this.ultraTilePanel2.Tiles.Add(this.ultraTile6);
            this.ultraTilePanel2.Tiles.Add(this.ultraTile7);
            // 
            // ultraTile4
            // 
            this.ultraTile4.Caption = "IRP 5";
            this.ultraTile4.Control = this.ultraButton17;
            this.ultraTile4.Controls.Add(this.ultraButton17);
            this.ultraTile4.Name = "ultraTile4";
            this.ultraTile4.PositionInNormalMode = new System.Drawing.Point(0, 0);
            this.ultraTile4.TabIndex = 4;
            // 
            // ultraButton17
            // 
            this.ultraButton17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraButton17.Location = new System.Drawing.Point(0, 18);
            this.ultraButton17.Name = "ultraButton17";
            this.ultraButton17.Size = new System.Drawing.Size(506, 196);
            this.ultraButton17.TabIndex = 1;
            this.ultraButton17.Text = "IRP 5";
            // 
            // ultraTile5
            // 
            this.ultraTile5.Caption = "IRP 3A";
            this.ultraTile5.Control = this.ultraButton18;
            this.ultraTile5.Controls.Add(this.ultraButton18);
            this.ultraTile5.Name = "ultraTile5";
            this.ultraTile5.PositionInNormalMode = new System.Drawing.Point(1, 0);
            this.ultraTile5.TabIndex = 5;
            // 
            // ultraButton18
            // 
            this.ultraButton18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraButton18.Location = new System.Drawing.Point(0, 18);
            this.ultraButton18.Name = "ultraButton18";
            this.ultraButton18.Size = new System.Drawing.Size(506, 196);
            this.ultraButton18.TabIndex = 2;
            this.ultraButton18.Text = "IRP 3A";
            // 
            // ultraTile6
            // 
            this.ultraTile6.Caption = "Employee Records";
            this.ultraTile6.Control = this.ultraButton19;
            this.ultraTile6.Controls.Add(this.ultraButton19);
            this.ultraTile6.Name = "ultraTile6";
            this.ultraTile6.PositionInNormalMode = new System.Drawing.Point(0, 1);
            this.ultraTile6.TabIndex = 6;
            // 
            // ultraButton19
            // 
            this.ultraButton19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraButton19.Location = new System.Drawing.Point(0, 18);
            this.ultraButton19.Name = "ultraButton19";
            this.ultraButton19.Size = new System.Drawing.Size(506, 196);
            this.ultraButton19.TabIndex = 2;
            this.ultraButton19.Text = "EMPLOYEE RECORDS";
            // 
            // ultraTile7
            // 
            this.ultraTile7.Caption = "Annula Employment Record";
            this.ultraTile7.Control = this.ultraButton20;
            this.ultraTile7.Controls.Add(this.ultraButton20);
            this.ultraTile7.Name = "ultraTile7";
            this.ultraTile7.PositionInNormalMode = new System.Drawing.Point(1, 1);
            this.ultraTile7.TabIndex = 7;
            // 
            // ultraButton20
            // 
            this.ultraButton20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraButton20.Location = new System.Drawing.Point(0, 18);
            this.ultraButton20.Name = "ultraButton20";
            this.ultraButton20.Size = new System.Drawing.Size(506, 196);
            this.ultraButton20.TabIndex = 2;
            this.ultraButton20.Text = "ANNUAL EMPLOYMENT RECORD";
            // 
            // tabWizard
            // 
            this.tabWizard.Controls.Add(this.ultraTabSharedControlsPage1);
            this.tabWizard.Controls.Add(this.ultraTabPageControl1);
            this.tabWizard.Controls.Add(this.ultraTabPageControl2);
            this.tabWizard.Controls.Add(this.ultraTabPageControl3);
            this.tabWizard.Controls.Add(this.ultraTabPageControl4);
            this.tabWizard.Controls.Add(this.ultraTabPageControl5);
            this.tabWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWizard.Location = new System.Drawing.Point(0, 27);
            this.tabWizard.Name = "tabWizard";
            this.tabWizard.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.btnNext,
            this.btnBack});
            this.tabWizard.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.tabWizard.Size = new System.Drawing.Size(1064, 553);
            this.tabWizard.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard;
            this.tabWizard.TabIndex = 0;
            ultraTab1.TabPage = this.ultraTabPageControl5;
            ultraTab1.Text = "Start/Welcome ";
            ultraTab2.TabPage = this.ultraTabPageControl1;
            ultraTab2.Text = "Manage employees";
            ultraTab3.TabPage = this.ultraTabPageControl2;
            ultraTab3.Text = "Enter Salary Amounts";
            ultraTab4.TabPage = this.ultraTabPageControl3;
            ultraTab4.Text = "Print Payroll";
            ultraTab5.TabPage = this.ultraTabPageControl4;
            ultraTab5.Text = "Other Reporting";
            this.tabWizard.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab1,
            ultraTab2,
            ultraTab3,
            ultraTab4,
            ultraTab5});
            this.tabWizard.SelectedTabChanged += new Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventHandler(this.tabWizard_SelectedTabChanged);
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Controls.Add(this.btnNext);
            this.ultraTabSharedControlsPage1.Controls.Add(this.btnBack);
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(1064, 553);
            // 
            // ultraToolTipManager1
            // 
            this.ultraToolTipManager1.ContainingControl = this;
            // 
            // _Form1_Toolbars_Dock_Area_Left
            // 
            this._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.MintCream;
            this._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 27);
            this._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left";
            this._Form1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 553);
            this._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // ultraToolbarsManager1
            // 
            appearance79.Image = ((object)(resources.GetObject("appearance79.Image")));
            this.ultraToolbarsManager1.Appearance = appearance79;
            this.ultraToolbarsManager1.DesignerFlags = 0;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.IsMainMenuBar = true;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            buttonTool2});
            ultraToolbar1.Text = "UltraToolbar1";
            this.ultraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            buttonTool3.SharedPropsInternal.ToolTipText = "Configure Payroll Options";
            buttonTool4.SharedPropsInternal.ToolTipText = "Configure Employer Details";
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool3,
            buttonTool4});
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // _Form1_Toolbars_Dock_Area_Right
            // 
            this._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.MintCream;
            this._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1064, 27);
            this._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right";
            this._Form1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 553);
            this._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Top
            // 
            this._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.MintCream;
            this._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top";
            this._Form1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1064, 27);
            this._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Bottom
            // 
            this._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.MintCream;
            this._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 580);
            this._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom";
            this._Form1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1064, 0);
            this._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // ultraPrintPreviewDialog1
            // 
            this.ultraPrintPreviewDialog1.Document = this.ultraPrintDocument1;
            this.ultraPrintPreviewDialog1.Name = "ultraPrintPreviewDialog1";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // OptionsTableAdapter
            // 
            this.OptionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.OptionsTableAdapter = null;
            this.tableAdapterManager.PAYEtablesTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayQuick.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OptionsbindingSource
            // 
            this.OptionsbindingSource.DataMember = "Options";
            this.OptionsbindingSource.DataSource = this.dataSet1;
            // 
            // employerbindingSource
            // 
            this.employerbindingSource.DataMember = "Employer";
            this.employerbindingSource.DataSource = this.dataSet1;
            // 
            // tLock1
            // 
            this.tLock1.Active = true;
            this.tLock1.ActiveCodeLength = 8;
            this.tLock1.ActiveFileName = "";
            this.tLock1.ApplicationIdentity = "";
            this.tLock1.HiddenLockFile = true;
            this.tLock1.LockFilePath = QALock.TLockFilePath.CurrentDir;
            this.tLock1.LockMode = QALock.TLockMode.Lock;
            this.tLock1.Options = new QALock.UniqeIdOptions(true, true, true, false, false, false, false, false);
            this.tLock1.SerialFileName = "";
            this.tLock1.SerialLength = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.tabWizard);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayQuick.co.za";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ultraTabPageControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox5)).EndInit();
            this.ultraGroupBox5.ResumeLayout(false);
            this.ultraTabPageControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraPanel3.ClientArea.ResumeLayout(false);
            this.ultraPanel3.ResumeLayout(false);
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ClientArea.PerformLayout();
            this.ultraPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor1)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.ultraTabPageControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraPanel6.ClientArea.ResumeLayout(false);
            this.ultraPanel6.ResumeLayout(false);
            this.ultraPanel5.ClientArea.ResumeLayout(false);
            this.ultraPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox6)).EndInit();
            this.ultraGroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox11)).EndInit();
            this.ultraGroupBox11.ResumeLayout(false);
            this.ultraGroupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor155)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox10)).EndInit();
            this.ultraGroupBox10.ResumeLayout(false);
            this.ultraGroupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor157)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor156)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox9)).EndInit();
            this.ultraGroupBox9.ResumeLayout(false);
            this.ultraGroupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox8)).EndInit();
            this.ultraGroupBox8.ResumeLayout(false);
            this.ultraGroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox7)).EndInit();
            this.ultraGroupBox7.ResumeLayout(false);
            this.ultraGroupBox7.PerformLayout();
            this.ultraPanel4.ClientArea.ResumeLayout(false);
            this.ultraPanel4.ResumeLayout(false);
            this.ultraPanel8.ClientArea.ResumeLayout(false);
            this.ultraPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).EndInit();
            this.ultraPanel7.ClientArea.ResumeLayout(false);
            this.ultraPanel7.ClientArea.PerformLayout();
            this.ultraPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditor2)).EndInit();
            this.ultraTabPageControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).EndInit();
            this.ultraTilePanel1.ResumeLayout(false);
            this.ultraTile1.ResumeLayout(false);
            this.ultraTile2.ResumeLayout(false);
            this.ultraTile3.ResumeLayout(false);
            this.ultraTile8.ResumeLayout(false);
            this.ultraTabPageControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox4)).EndInit();
            this.ultraGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel2)).EndInit();
            this.ultraTilePanel2.ResumeLayout(false);
            this.ultraTile4.ResumeLayout(false);
            this.ultraTile5.ResumeLayout(false);
            this.ultraTile6.ResumeLayout(false);
            this.ultraTile7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabWizard)).EndInit();
            this.tabWizard.ResumeLayout(false);
            this.ultraTabSharedControlsPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinTabControl.UltraTabControl tabWizard;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.Misc.UltraButton btnNext;
        private Infragistics.Win.Misc.UltraButton btnBack;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl4;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox4;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl5;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel3;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter2;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor6;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
        private Infragistics.Win.Misc.UltraButton ultraButton4;
        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox1;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter4;
        private Infragistics.Win.Misc.UltraPanel ultraPanel6;
        private Infragistics.Win.Misc.UltraButton ultraButton10;
        private Infragistics.Win.Misc.UltraButton ultraButton8;
        private Infragistics.Win.Misc.UltraButton ultraButton9;
        private Infragistics.Win.Misc.UltraButton ultraButton6;
        private Infragistics.Win.Misc.UltraButton ultraButton7;
        private Infragistics.Win.Misc.UltraPanel ultraPanel5;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter3;
        private Infragistics.Win.Misc.UltraPanel ultraPanel4;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter5;
        private Infragistics.Win.Misc.UltraPanel ultraPanel8;
        private Infragistics.Win.Misc.UltraPanel ultraPanel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel22;
        private Infragistics.Win.Misc.UltraLabel ultraLabel21;
        private Infragistics.Win.Misc.UltraButton ultraButton12;
        private Infragistics.Win.Misc.UltraButton ultraButton11;
        private Infragistics.Win.Misc.UltraLabel ultraLabel23;
        private Infragistics.Win.UltraWinToolTip.UltraToolTipManager ultraToolTipManager1;
        private Infragistics.Win.Misc.UltraButton ultraButton5;
        private Infragistics.Win.Misc.UltraButton ultraButton3;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private Infragistics.Win.Misc.UltraButton ultraButton13;
        private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel1;
        private Infragistics.Win.Misc.UltraTile ultraTile1;
        private Infragistics.Win.Misc.UltraTile ultraTile2;
        private Infragistics.Win.Misc.UltraButton ultraButton14;
        private Infragistics.Win.Misc.UltraButton ultraButton15;
        private Infragistics.Win.Misc.UltraTile ultraTile3;
        private Infragistics.Win.Misc.UltraButton ultraButton16;
        private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel2;
        private Infragistics.Win.Misc.UltraTile ultraTile4;
        private Infragistics.Win.Misc.UltraButton ultraButton17;
        private Infragistics.Win.Misc.UltraTile ultraTile5;
        private Infragistics.Win.Misc.UltraButton ultraButton18;
        private Infragistics.Win.Misc.UltraTile ultraTile6;
        private Infragistics.Win.Misc.UltraButton ultraButton19;
        private Infragistics.Win.Misc.UltraTile ultraTile7;
        private Infragistics.Win.Misc.UltraButton ultraButton20;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid2;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private DataSet1TableAdapters.PayrollTableAdapter payrollTableAdapter;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel24;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditor2;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.EmployerTableAdapter employerTableAdapter;
        private DataSet1TableAdapters.OptionsTableAdapter OptionsTableAdapter;
        private System.Windows.Forms.BindingSource OptionsbindingSource;
        private System.Windows.Forms.BindingSource employerbindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabel25;
        private Infragistics.Win.Misc.UltraButton ultraButton21;
        private Infragistics.Win.Misc.UltraButton ultraButton22;
        private Infragistics.Win.Misc.UltraButton ultraButton23;
        private Infragistics.Win.Printing.UltraPrintPreviewDialog ultraPrintPreviewDialog1;
        private Infragistics.Win.Printing.UltraPrintDocument ultraPrintDocument1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel20;
        private Infragistics.Win.Misc.UltraLabel ultraLabel14;
        private Infragistics.Win.Misc.UltraLabel ultraLabel15;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor157;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor156;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor155;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor10;
        private Infragistics.Win.Misc.UltraLabel ultraLabel19;
        private Infragistics.Win.Misc.UltraLabel ultraLabel18;
        private Infragistics.Win.Misc.UltraLabel ultraLabel17;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel16;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraLabel ultraLabel26;
        private Infragistics.Win.Misc.UltraLabel ultraLabel27;
        private Infragistics.Win.Misc.UltraLabel ultraLabel28;
        private Infragistics.Win.Misc.UltraButton ultraButton24;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit9;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit8;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit7;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit6;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit5;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit4;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit3;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit2;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMaskedEdit1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox9;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox8;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox7;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox10;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox11;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel13;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private QALock.TLock tLock1;
        private Infragistics.Win.Misc.UltraTile ultraTile8;
        private Infragistics.Win.Misc.UltraButton ultraButton25;
    }
}

