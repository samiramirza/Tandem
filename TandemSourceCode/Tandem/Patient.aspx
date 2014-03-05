<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="Tandem.Patient" %>

<html>
<head>


    <link rel="stylesheet" type="text/css" href="Scripts/siteSpecific.css" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>

</head>
<body>

    <div class="outer-div">

        <div class="inner-div">
            <%--  main form--%>
            <form id="myform" runat="server">
                <div class="content">
                    <section name="MultiColumnWrapper" class="content-section white-bg">
                   <div id="button_nav">
                            <div id="pnlNavigation1">
                                <asp:Button ID="btnTopNav3" class="button step_one_on" runat="server" OnClientClick="return false;" TabIndex="-1" />
                                <a href="#">
                                    <asp:Button ID="btnTopNav1" class="button step_four_off" runat="server" TabIndex="-1" OnClientClick="return false;"/></a>
                                <a href="#">
                                    <asp:Button ID="btnTopNav2" class="button step_two_off" runat="server" TabIndex="-1" OnClientClick="return false;" /></a>
                            </div>

                            <div id="pnlNavigation2">
                                <a href="javascript:void(null)">
                                    <asp:Button ID="btnTopNav6" class="button step_one_off" runat="server" TabIndex="-1" OnClientClick="return false;" /></a>
                                <asp:Button ID="btnTopNav5" class="button step_two_on" runat="server" TabIndex="-1" OnClientClick="return false;" />
                                <a href="javascript:void(null)">
                                    <asp:Button ID="btnTopNav4" class="button step_four_off" runat="server" TabIndex="-1" OnClientClick="return false;" /></a>

                            </div>

                            <div id="pnlNavigation3">
                                <a href="javascript:void(null)">
                                    <asp:Button ID="btnTopNav9" class="button step_one_off" runat="server" TabIndex="-1" OnClientClick="return false;" /></a>
                                <a href="javascript:void(null)">
                                    <asp:Button ID="btnTopNav8" class="button step_two_off" runat="server" TabIndex="-1" OnClientClick="return false;" /></a>
                                <asp:Button ID="btnTopNav7" class="button step_four_on" runat="server" TabIndex="-1" OnClientClick="return false;" />

                            </div>
                        </div>

                        <div class="mainform">
                            <div id="patientInfo">
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtFrst" runat="server" MaxLength="100" TabIndex="1" placeholder="First Name"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <div class="holder">Gender:</div>
                                        <div class="radiobtn">
                                            <asp:RadioButtonList ID="radGender" TabIndex="4" runat="server" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="200px">
                                                <asp:ListItem Value="Male">Male</asp:ListItem>
                                                <asp:ListItem Value="Female">Female</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtMiddle" MaxLength="100" TabIndex="2" runat="server" placeholder="Middle Name"></asp:TextBox>

                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtDOB" runat="server" TabIndex="5" placeholder="Date of Birth (MM/DD/YYYY)"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtLast" MaxLength="100" TabIndex="3" runat="server" placeholder="Last Name"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtSecurity" runat="server" TabIndex="6" MaxLength="9" placeholder="Social Security Number"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row" style="margin: 42px 0 !important;">
                                    <div class="col">
                                        <asp:TextBox ID="txtaddress" MaxLength="200" TabIndex="7" runat="server" placeholder="Street Address"
                                            Height="138px" TextMode="MultiLine" Width="455px" style="resize:none"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtCity" MaxLength="100" TabIndex="8" runat="server" placeholder="City"></asp:TextBox>
                                        <asp:TextBox ID="txtState" runat="server" TabIndex="9" MaxLength="2" placeholder="State"></asp:TextBox>
                                        <asp:TextBox ID="txtZip" runat="server" TabIndex="10" MaxLength="10" placeholder="Zipcode"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtPrimry" runat="server" MaxLength="20" TabIndex="11" placeholder="Primary Phone"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtEmail" runat="server" TabIndex="14" MaxLength="100" placeholder="Email Address"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtSecondry" runat="server" MaxLength="20" TabIndex="12" placeholder="Secondary Phone"></asp:TextBox>

                                    </div>
                                    <div class="colright">
                                        <p class="holder">Preferred contact:</p>
                                        <div class="radiobtn">
                                            <asp:RadioButtonList ID="radMethdofContect" TabIndex="15" runat="server" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="200px">
                                                <asp:ListItem Value="Phone">Phone</asp:ListItem>
                                                <asp:ListItem Value="Email">Email</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtTertry" runat="server" MaxLength="20" TabIndex="13" placeholder="Tertiary Phone"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <p class="holder">Best time to call:</p>
                                        <div class="radiobtn">
                                            <asp:RadioButtonList ID="radBstTime" runat="server" TabIndex="16" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="300px">
                                                <asp:ListItem Value="Morning">Morning</asp:ListItem>
                                                <asp:ListItem Value="Afternoon">Afternoon</asp:ListItem>
                                                <asp:ListItem Value="Evening">Evening</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row" style="margin: 42px 0 !important;">
                                    <div class="col1">
                                        <asp:TextBox ID="txtEmrgncyContct" runat="server" MaxLength="100" TabIndex="17" placeholder="Emergency Contact"></asp:TextBox>
                                    </div>
                                    <div class="col1" style="margin-left: 17px;">
                                        <asp:TextBox ID="txtEmrgncyPhone" MaxLength="20" TabIndex="18" runat="server" placeholder="Emergency Phone"></asp:TextBox>
                                    </div>
                                    <div class="col1" style="margin-left: 17px;">
                                        <asp:TextBox ID="txtEmrgncyRealtnship" TabIndex="19" MaxLength="100" runat="server" placeholder="Emergency Relationship"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row">
                                    <input type="button" id="BtnPatientInfo" tabindex="19" value="Next" class="btncss" />
                                </div>

                            </div>


                            <div id="providerInfo">

                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtProviderName" MaxLength="100" TabIndex="20" runat="server" placeholder="Prescribing Provider's Name"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtSpeciality" MaxLength="100" TabIndex="25" runat="server" placeholder="Speciality"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtStreetAddress" MaxLength="200" TabIndex="21" runat="server" placeholder="Office Street Address"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtPhonePres" TabIndex="26" MaxLength="20" runat="server" placeholder="Phone Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtCityPres" TabIndex="22" MaxLength="100" runat="server" placeholder="City"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtFaxPres" TabIndex="27" MaxLength="20" runat="server" placeholder="Fax Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtStatePres" MaxLength="2" TabIndex="23" runat="server" placeholder="State"> </asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtGrupPractis" MaxLength="100" TabIndex="28" runat="server" placeholder="Group Practice Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtZipPres" TabIndex="24" MaxLength="10" runat="server" placeholder="Zipcode"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtOfficeContct" MaxLength="100" TabIndex="29" runat="server" placeholder="Office Contact Name"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row" style="margin: 42px 0 !important;">
                                    <input type="button" id="BtnSubscribe" value="Next" tabindex="29" class="btncss" />
                                </div>
                            </div>

                            <div id="insuranceInfo">
                                <p class="section-summary">PRIMARY INSURANCE INFORMATION (please provide a copy of the <span style="font-style: italic; font-weight: bold; text-decoration: underline;">front and back</span> of your insurance card).</p>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtNameIns" runat="server" MaxLength="100" TabIndex="30" placeholder="Insurance Name"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtPhoneIns" MaxLength="20" TabIndex="39" runat="server" placeholder="Phone Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtStreetAdressIns" runat="server" MaxLength="200" TabIndex="31" placeholder="Mailing Street Address"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtFaxIns" MaxLength="20" TabIndex="40" runat="server" placeholder="Fax Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtCityIns" runat="server" MaxLength="100" TabIndex="32" placeholder="City"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtPolNumIns" runat="server" MaxLength="100" TabIndex="41" placeholder="Policy Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtStateIns" runat="server" MaxLength="2" TabIndex="33" placeholder="State"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtGrupIns" runat="server" MaxLength="100" TabIndex="42" placeholder="Group Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <asp:TextBox ID="txtZipIns" runat="server" MaxLength="10" TabIndex="34" placeholder="Zipcode"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <p class="holder">Plan Type:</p>
                                        <div class="radiobtn">
                                            <asp:RadioButtonList ID="radPlanTypeIns" runat="server" TabIndex="43" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="315px">
                                                <asp:ListItem Value="HMO">HMO</asp:ListItem>
                                                <asp:ListItem Value="PPO">PPO</asp:ListItem>
                                                <asp:ListItem Value="EPO">EPO</asp:ListItem>
                                                <asp:ListItem Value="Other">Other</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>

                                    </div>

                                </div>
                                <div class="row">
                                    <div class="col">

                                        <asp:TextBox ID="txtPolNameIns" runat="server" MaxLength="100" TabIndex="35" placeholder="Policy Holder's Name"></asp:TextBox>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtPolDOBIns" runat="server" TabIndex="44" placeholder="Policy Holder's DOB (MM/DD/YYYY)"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <p class="holder">Relationship:</p>
                                        <div class="radiobtn">
                                            <asp:RadioButtonList ID="radRelationIns" runat="server" TabIndex="36" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="315px">
                                                <asp:ListItem Value="Self">Self</asp:ListItem>
                                                <asp:ListItem Value="Spouse">Spouse</asp:ListItem>
                                                <asp:ListItem Value="Child">Child</asp:ListItem>
                                                <asp:ListItem Value="Other">Other</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>

                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtPolSSNIns" runat="server" TabIndex="45" MaxLength="9" placeholder="Policy Holder's Social Security Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <p class="holder">If Medicare:</p>
                                        <div class="radiobtn">
                                            <asp:CheckBox ID="radMedicareIns" TabIndex="54" runat="server" />
                                            <label>Part B</label>
                                        </div>
                                    </div>
                                    <div class="colright">
                                        <asp:TextBox ID="txtEmplolyerIns" runat="server" TabIndex="46" MaxLength="100" placeholder="Employer's Name"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="row" style="margin-bottom: 42px !important;">
                                    <div class="col">
                                        <asp:TextBox ID="txtMediNumIns" runat="server" TabIndex="38" MaxLength="100" placeholder="Medicare Number"></asp:TextBox>
                                    </div>
                                </div>


                                <div id="Div1" style="float: left;">
                                    <div style="float: left; width: 3%;">
                                        <input type="checkbox" id="chek_secondry" />
                                    </div>
                                    <p class="section-summary" style="width: 900px;">SECONDARY INSURANCE INFORMATION (please provide a copy of the <span style="font-style: italic; font-weight: bold; text-decoration: underline;">front and back</span> of your insurance card).</p>
                                    <div id="secondry_ins" style="float: left;">
                                        <div class="row">
                                            <div class="col">
                                                <asp:TextBox ID="txtNameSec" runat="server" TabIndex="47" MaxLength="100" placeholder="Insurance Name"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtPhnSec" TabIndex="56" MaxLength="20" runat="server" placeholder="Phone Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <asp:TextBox ID="txtStreetAdresSec" runat="server" TabIndex="48" MaxLength="200" placeholder="Mailing Street Address"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtFaxSec" TabIndex="57" MaxLength="20" runat="server" placeholder="Fax Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <asp:TextBox ID="txtCitySec" runat="server" placeholder="City" TabIndex="49" MaxLength="100"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtPolNumSec" runat="server" TabIndex="58" MaxLength="100" placeholder="Policy Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <asp:TextBox ID="txtStateSec" runat="server" TabIndex="50" MaxLength="2" placeholder="State"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtGroupSec" runat="server" TabIndex="59" MaxLength="100" placeholder="Group Number"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <asp:TextBox ID="txtZipSec" runat="server" TabIndex="51" MaxLength="10" placeholder="Zipcode"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <p class="holder">Plan Type:</p>
                                                <div class="radiobtn">
                                                    <asp:RadioButtonList ID="radPlanTypeSec" runat="server" TabIndex="43" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="315px">
                                                        <asp:ListItem Value="HMO">HMO</asp:ListItem>
                                                        <asp:ListItem Value="PPO">PPO</asp:ListItem>
                                                        <asp:ListItem Value="EPO">EPO</asp:ListItem>
                                                        <asp:ListItem Value="Other">Other</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </div>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">

                                                <asp:TextBox ID="txtPolNameSec" runat="server" TabIndex="52" MaxLength="100" placeholder="Policy Holder's Name"></asp:TextBox>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtPolDOBSec" runat="server" TabIndex="44" placeholder="Policy Holder's DOB (MM/DD/YYYY)"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col">
                                                <p class="holder">Relationship:</p>
                                                <div class="radiobtn">
                                                    <asp:RadioButtonList ID="radRelationSec" runat="server" TabIndex="53" RepeatDirection="Horizontal" CellPadding="1" CellSpacing="1" Width="315px">
                                                        <asp:ListItem Value="Self">Self</asp:ListItem>
                                                        <asp:ListItem Value="Spouse">Spouse</asp:ListItem>
                                                        <asp:ListItem Value="Child">Child</asp:ListItem>
                                                        <asp:ListItem Value="Other">Other</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </div>

                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtPolSSNSec" TabIndex="62" MaxLength="9" runat="server" placeholder="Policy Holder's Social Security Number"></asp:TextBox>
                                            </div>
                                        </div>



                                        <div class="row">
                                            <div class="col">
                                                <p class="holder">If Medicare:</p>
                                                <div class="radiobtn">
                                                    <asp:CheckBox ID="radMedicareSec" runat="server" TabIndex="54" />
                                                    <label>Part B	</label>
                                                </div>
                                            </div>
                                            <div class="colright">
                                                <asp:TextBox ID="txtEmployerSec" runat="server" TabIndex="100" MaxLength="100" placeholder="Employer's Name"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="row" style="margin-bottom: 42px !important;">
                                            <div class="col">
                                                <asp:TextBox ID="txtMediNumSec" runat="server" TabIndex="55" MaxLength="100" placeholder="Medicare Number"></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                                <div class="row" style="margin-bottom: 42px !important;">
                                    <asp:Button ID="btnInsurance" runat="server" Text="Next" class="btncss" TabIndex="63" OnClientClick="return submitform();" OnClick="btnInsurance_Click" />
                                </div>
                            </div>
                        </div>
                    </section>
                </div>

            </form>

            <%--  main form ends--%>
        </div>

    </div>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script src="Scripts/jquery.validate.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui-1.8.20.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.maskedinput.js" type="text/javascript"></script>
    <script src="Scripts/jquery.placeholder.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="Scripts/jquery.ui.all.css">
    <link rel="stylesheet" type="text/css" href="Scripts/jquery.ui.datepicker.css" />


    <script type="text/javascript">
        $(function () { $('input, textarea').placeholder(); });


        $(document).ready(function () {

            if (($.browser.msie) == true) {
                if (($.browser.version) == '9.0' || ($.browser.version) == '8.0') {
                  
                    $('label').css("margin-top", "3px");
                    $('input[type="text"]').css({ "height": "22px" });
                    $('.col, .colright, input[type="text"],textarea, input[type="select"]').css({ "width": "442px" });
                    $('.col1, .col1 input[type="text"]').css({ "width": "288px", "height": "22px" });
                    $('.colright').css("margin-left", "40px");
                    $('.col1:nth-child(2), .col1:nth-child(3)').css("margin-left", "30px");
                    $('.radiobtn').css("margin-left", "10px");
                    $('input[type="checkbox"]').css({ "margin-top": "0px" });
                    $('#chek_secondry').css({ "margin-top": "-3px" });
                    $('.holder').css("padding-top", "6px");
                }
                else if (($.browser.version) == '10.0') {
                    $('label').css("margin-top", "3px");                  
                    $('input[type="checkbox"]').css({ "margin-top": "0px" });
                    $('#chek_secondry').css({ "margin-top": "-3px" });
                    $('.col1, .col1 input[type="text"]').css({ "height": "37px" });
                    $('input[type="text"]').css({ "height": "38px" });
                }
            }

            $("#txtPrimry, #txtSecondry, #txtTertry, #txtEmrgncyPhone, #txtPhonePres, #txtFaxPres").mask("999-999-9999?x9999");
            $("#txtPhoneIns, #txtFaxIns, #txtPhnSec, #txtFaxSec").mask("999-999-9999?x9999");

            $("#pnlNavigation2").css("display", "none");
            $("#pnlNavigation3").css("display", "none");
            $("#providerInfo").css("display", "none");
            $("#insuranceInfo").css("display", "none");
          //  $("#patientInfo").css("display", "none");

            $("#chek_secondry").removeAttr("checked");
            $("#radMedicareIns").removeAttr("checked");
            $("#radMedicareSec").removeAttr("checked");
            $('#txtMediNumIns').hide();
            $('#txtMediNumSec').hide();

            $('form').find("input[type=text], textarea").val("");
            $('#secondry_ins').find("input[type=text], input[type=radio], input[type=checkbox]").attr("disabled", true);
            $('#secondry_ins').find("input[type=text]").css("background", "#dedede");

            $("#txtDOB").attr("readonly", "readonly");
            $("#txtPolDOBIns").attr("readonly", "readonly");
            $("#txtPolDOBSec").attr("readonly", "readonly");

            $("#txtDOB").datepicker({
                dateFormat: "mm/dd/yy",
                changeMonth: true,
                changeYear: true,
                yearRange: '1900:+0'
            });

            $("#txtPolDOBIns").datepicker({
                dateFormat: "mm/dd/yy",
                changeMonth: true,
                changeYear: true,
                yearRange: '1900:+0'
            });
            $("#txtPolDOBSec").datepicker({
                dateFormat: "mm/dd/yy",
                changeMonth: true,
                changeYear: true,
                yearRange: '1900:+0'
            });
            $("#radMedicareIns").click(function () {
                if (this.checked == true)
                    $('#txtMediNumIns').show();
                else {
                    $('#txtMediNumIns').hide();
                    $("#myform").valid();
                }
            });
            $("#radMedicareSec").click(function () {
                if (this.checked == true)
                    $('#txtMediNumSec').show();
                else {
                    $('#txtMediNumSec').hide();
                    $("#myform").valid();
                }
            });

            $("#chek_secondry").click(function () {
                if (this.checked == true) {
                    $('#secondry_ins').find("input[type=text], input[type=radio], input[type=checkbox]").attr("disabled", false);
                    $('#secondry_ins').find("input[type=text], input[type=radio], input[type=checkbox]").css("background", "#fff");

                }
                else {
                    $('#secondry_ins').find("input[type=text], input[type=radio], input[type=checkbox]").attr("disabled", true);
                    $('#secondry_ins').find("input[type=text], input[type=radio], input[type=checkbox]").css("background", "#dedede");
                    $('#secondry_ins').find("input[type=radio], input[type=checkbox]").css("background", "#fff");
                    $('#secondry_ins').find("input[type=text]").val("");
                    $("#radMedicareSec").removeAttr("checked");
                    $("input:radio[name=radRelationSec]").each(function (i) {
                        this.checked = false;
                        
                    });
                    $("input:radio[name=radPlanTypeSec]").each(function (i) {
                        this.checked = false;
                    });
                    $('#txtMediNumSec').hide();
                    $("#myform").valid();
                }
            });


            $.validator.addMethod("validreq", function (value, element) {
                var name = $(element).attr('id');

                if (value == "" || value == $('#' + name).attr('placeholder'))
                    return false;
                else
                    return true;

            }, "* Required");

            $.validator.addMethod("validSSN", function (value,element) {
                var name = $(element).attr('id');
                if (value == "" || value == $('#' + name).attr('placeholder'))
                    return true;
                else {
                    var pattern = /^\d{9}$/;
                    return (pattern.test(value) > 0);
                }
            }, "Please enter a valid social security number. For ex: 000000000.");

            $.validator.addMethod("validZIP", function (value) {

                var pattern = /^\d{5}(-\d{4})?$/;
                return (pattern.test(value) > 0);
            }, "Please enter a valid zipcode. For ex: 12345 or 12345-6789.");

            $.validator.addMethod("validmedicareprim", function (value,element) {

                if ($('input[name=radMedicareIns]').is(':checked') == false)
                    return true;
                else {
                    var name = $(element).attr('id');

                    if (value == "" || value == $('#' + name).attr('placeholder'))
                        return false;
                    else
                        return true;
                }
            }, "* Required");

            $.validator.addMethod("validmedicaresec", function (value,element) {

                if ($('input[name=radMedicareSec]').is(':checked') == false)
                    return true;
                else {
                    var name = $(element).attr('id');

                    if (value == "" || value == $('#' + name).attr('placeholder'))
                        return false;
                    else
                        return true;
                }

            }, "* Required");

            $.validator.addMethod("validPolicyInsName", function (value,element) {

                var insVal = $('input:radio[name=radRelationIns]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");

            $.validator.addMethod("validPolicyInsDOB", function (value,element) {

                var insVal = $('input:radio[name=radRelationIns]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");

            $.validator.addMethod("validPolicyInsSSN", function (value,element) {

                var insVal = $('input:radio[name=radRelationIns]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");
            $.validator.addMethod("validPolicySecName", function (value,element) {

                var insVal = $('input:radio[name=radRelationSec]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");

            $.validator.addMethod("validPolicySecDOB", function (value,element) {

                var insVal = $('input:radio[name=radRelationSec]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");

            $.validator.addMethod("validPolicySecSSN", function (value,element) {

                var insVal = $('input:radio[name=radRelationSec]:checked').val();

                if (typeof insVal == "undefined")
                    return true;
                else {
                    if (insVal == "Self")
                        return true;
                    else {
                        var name = $(element).attr('id');

                        if (value == "" || value == $('#' + name).attr('placeholder'))
                            return false;
                        else
                            return true;
                    }
                }
            }, "* Required");


            $.validator.addMethod("validPhone", function (value, element) {
                var name = $(element).attr('id');
                alert(value);
                if (value == "" || value == $('#' + name).attr('placeholder'))
                    return true;
                else {
                    var pattern = /^((\(\d{3}\) ?)|(\d{3}-))\d{3}-\d{4}$/;
                    var pattern1 = /^((\(\d{3}\) ?)|(\d{3}-))\d{3}-\d{4}[Xx]\d{4}$/;
                    if (pattern.test(value) > 0) {

                        return (pattern.test(value) > 0)

                    }
                    else if (pattern1.test(value) > 0) {

                        return (pattern1.test(value) > 0)
                    }
                }

            }, "Please enter a valid phone number. For ex: 000-000-0000 or 000-000-0000x0000.");

            $.validator.addMethod("ValidPhoneMask", function (value, element) {
                var name = $(element).attr('id');
                var val = value;
                var pos = val.charAt(13);
                //alert(pos);
                //alert($.isNumeric(pos));
                if (!$.isNumeric(pos))
                    val = val.substring(0, 12);
           //     alert(val);
                if (val == "" || val == $('#' + name).attr('placeholder'))
                    return true;
                else {
                    var pattern = /^((\(\d{3}\) ?)|(\d{3}-))\d{3}-\d{4}$/;
                    var pattern1 = /^((\(\d{3}\) ?)|(\d{3}-))\d{3}-\d{4}[Xx]\d{4}$/;


                    if (pattern.test(val) > 0) {
                        return (pattern.test(val) > 0)
                    }
                    else if (pattern1.test(val) > 0) {
                        return (pattern1.test(val) > 0)
                    }
                }
            }, "Please enter a valid phone number. For ex: 000-000-0000 or 000-000-0000x0000.");


            var validator = $("#myform").validate({
                rules: {
                    txtFrst: {
                        validreq: true
                    },
                    txtLast: {
                        validreq: true
                    },
                    txtMiddle: {
                        validreq: true
                    },
                    txtaddress: {
                        validreq: true,
                        maxlength: 200
                    },
                    txtDOB: {
                        validreq: true
                    },
                    txtCity: {
                        validreq: true
                    },
                    radGender: {
                        required: true
                    },
                    txtState: {
                        validreq: true,
                        maxlength: 5
                    },
                    txtZip: {
                        validreq: true,
                        validZIP: true
                    },
                    txtSecurity: {
                        validreq: true,
                        maxlength: 40,
                        validSSN: true
                    },
                    txtPrimry: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    txtSecondry: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    txtTertry: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    radMethdofContect: {
                        required: true
                    },
                    radBstTime: {
                        required: true
                    },
                    txtEmail: {
                        validreq: true,
                        email: true
                    },
                    txtEmrgncyContct: {
                        validreq: true
                    },
                    txtEmrgncyPhone: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    txtEmrgncyRealtnship: {
                        validreq: true
                    },
                    txtProviderName: {
                        validreq: true
                    },
                    txtSpeciality: {
                        validreq: true
                    },
                    txtStreetAddress: {
                        validreq: true
                    },
                    txtPhonePres: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    txtCityPres: {
                        validreq: true
                    },
                    txtStatePres: {
                        validreq: true,
                        maxlength: 5 
                    },
                    txtZipPres: {
                        validreq: true,
                        validZIP: true
                    },
                    txtFaxPres: {
                        validreq: true,
                        ValidPhoneMask: true
                    },
                    txtGrupPractis: {
                        validreq: true
                    },
                    txtOfficeContct: {
                        validreq: true
                    },
                    txtNameIns: {
                        validreq: true
                    },
                    txtStreetAdressIns: {
                        validreq: true
                    },
                    txtCityIns: {
                        validreq: true
                    },
                    txtStateIns: {
                        validreq: true,
                        maxlength:5
                    },
                    txtZipIns: {
                        validreq: true,
                        validZIP: true
                    },
                    txtPolNumIns: {
                        validreq: true
                    },
                    txtGrupIns: {
                        validreq: true
                    },
                    txtPolNameIns: {
                        validreq: false,
                        validPolicyInsName: true
                    },
                    radRelationIns: {
                        required: true
                    },
                    radMedicareIn: {
                        required: true
                    },
                    txtMediNumIns: {
                      validmedicareprim: true
                    },
                  
                    txtPhoneIns: {
                        required: false,
                        ValidPhoneMask: true
                    },
                    txtFaxIns: {
                        required: false,
                        ValidPhoneMask: true
                    },
                    txtPolDOBIns: {
                        required: false,
                        validPolicyInsDOB: true,
                    },
                    txtPolSSNIns: {
                        required: false,
                        maxlength:40,
                        validPolicyInsSSN: true,
                        validSSN: true
                    },
                    txtNameSec: {
                        validreq: true
                    },
                    txtStreetAdresSec: {
                        validreq: true
                    },
                    txtCitySec: {
                        validreq: true
                    },
                    txtStateSec: {
                        validreq: true,
                        maxlength:5
                    },
                    txtZipSec: {
                        validreq: true,
                        validZIP: true
                    },
                    txtPolNumSec: {
                        validreq: true
                    },
                    txtGroupSec: {
                        validreq: true
                    },
                    txtPolNameSec: {
                        required: false,
                        validPolicySecName: true
                    },
                    radRelationSec: {
                        required: true
                    },
                    txtMediNumSec: {
                     
                        validmedicaresec: true
                    },
                 
                    txtPhnSec: {
                        ValidPhoneMask: true
                    },
                    txtFaxSec: {
                        ValidPhoneMask: true
                    },
                    txtPolDOBSec: {
                        required: false,
                        validPolicySecDOB: true
                    },
                    txtPolSSNSec: {
                        required: false,
                        maxlength: 40,
                        validPolicySecSSN: true,
                        validSSN: true
                    }
                },
                errorPlacement: function (error, element) {
                    if (element.attr("name") == "radGender") {
                        error.insertAfter("#radGender");
                    }

                    if (element.attr("name") == "radMethdofContect") {
                        error.insertAfter("#radMethdofContect");
                    }

                    if (element.attr("name") == "radBstTime") {
                        error.insertAfter("#radBstTime");
                    }

                    if (element.attr("name") == "radRelationIns") {
                        error.insertAfter("#radRelationIns");
                    }

                    if (element.attr("name") == "radMedicareIn") {
                        error.insertAfter("#radMedicareIn");
                    }
                    if (element.attr("name") == "radRelationSec") {
                        error.insertAfter("#radRelationSec");
                    }

                    if (element.attr("name") == "radMedicareSec") {
                        error.insertAfter("#radMedicareSec");
                    }

                    if (element.attr("name") != "radGender" && element.attr("name") != "radMethdofContect" && element.attr("name") != "radBstTime" &&
                 element.attr("name") != "radRelationIns" && element.attr("name") != "radMedicareIn" && element.attr("name") != "radRelationSec" &&
                  element.attr("name") != "radMedicareSec") {
                        error.insertAfter(element);
                        error.css({ "top": "-5px" });
                    }

                }

            });


            $.extend($.validator.messages, { required: "* Required" });

            $("#BtnPatientInfo").on('click', function () {
                // ($(this).val() == '' || $(this).val() == $(this).attr('placeholder'))

                var status = $("#myform").valid();
                if (status) {
                    $("#pnlNavigation1").hide();
                    $("#pnlNavigation2").show();

                    $("#pnlNavigation3").hide();
                    $("#patientInfo").fadeOut(400);
                    $("html, body").animate({ scrollTop: 0 }, 500);
                    $("#providerInfo").delay(600).fadeIn(800);

                    $("#insuranceInfo").hide();

                }
            });

            $("#BtnSubscribe").on('click', function () {

                var status = $("#myform").valid();
                if (status) {
                    $("#pnlNavigation1").hide();
                    $("#pnlNavigation2").hide();
                    $("#pnlNavigation3").show();

                    $("#patientInfo").hide();
                    $("#providerInfo").fadeOut(400);
                    $("html, body").animate({ scrollTop: 0 }, 500);
                    $("#insuranceInfo").delay(600).fadeIn(800);

                }
            });



        });


        function submitform() {

            var status = $("#myform").valid();

            if (status) {
                $("#pnlNavigation1").hide();
                $("#pnlNavigation2").hide();
                $("#pnlNavigation3").show();
                $("#patientInfo").hide();
                $("#providerInfo").hide();
                $("#insuranceInfo").show();

                return true;
            }
            return false;
        }


    </script>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
</body>
</html>
