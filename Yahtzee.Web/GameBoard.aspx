<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameBoard.aspx.cs" Inherits="Yahtzee.Web.About" %>

   

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        try {
            
            var metaViewPort = document.createElement('meta');
            metaViewPort.setAttribute('name', 'viewport');

            if (screen.width <= 730) {
                metaViewPort.setAttribute('content', 'width=730');
            } else if (screen.width <= 1024) {
                metaViewPort.setAttribute('content', 'width=1024');
            } else {
                metaViewPort.setAttribute('content', 'width=device-width');
            }
            var head = document.getElementsByTagName('head')[0];
            if (head) {
                head.appendChild(metaViewPort);
            }
        } catch(e) {
            //nevermind
        }

        function ckZero(id) {

            var value = document.getElementById(id).innerText;

            if (value == "" || value == "0") {
                return window.confirm("Are you sure?");
            }

            return true;
        }

    </script>
    <style>
        h1 {
            display: inline;
        }
        .auto-style1 {
            color: #FF0066;
        }
    </style>
    <div id="Game" runat="server">
    <br />
    <div style=" float:right" >
        <asp:Table ID="tableScoring"  runat="server" HorizontalAlign="Right" ViewSateMode="Enabled" BorderWidth="1px" GridLines="Both">
            <asp:TableHeaderRow BorderWidth="1px">
                <asp:TableHeaderCell>Category</asp:TableHeaderCell>
                <asp:TableHeaderCell>Score Value</asp:TableHeaderCell>
                <asp:TableHeaderCell>Save</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow BackColor="#0066cc" ForeColor="White">
                <asp:TableCell>UPPER SECTION</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Aces</asp:TableCell>
                <asp:TableCell ID="acesScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnAces" Text="Save" runat="server" OnClick="btnAces_Click"/>  
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Twos</asp:TableCell>
                <asp:TableCell ID="twosScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnTwos" Text="Save" runat="server" OnClick="btnTwos_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Threes</asp:TableCell>
                <asp:TableCell ID="threesScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnThrees" Text="Save" runat="server" OnClick="btnThrees_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Fours</asp:TableCell>
                <asp:TableCell ID="foursScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnFours" Text="Save" runat="server" OnClick="btnFours_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Fives</asp:TableCell>
                <asp:TableCell ID="fivesScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnFives" Text="Save" runat="server" OnClick="btnFives_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Sixes</asp:TableCell>
                <asp:TableCell ID="sixesScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnSixes" Text="Save" runat="server" OnClick="btnSixes_Click" />
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow BackColor="#0066cc" ForeColor="White">
                <asp:TableCell >LOWER SECTION</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>3 of a kind</asp:TableCell>
                <asp:TableCell ID="ThreeofKindScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnThreeKind" Text="Save" runat="server" OnClick="btnThreeKind_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>4 of a kind</asp:TableCell>
                <asp:TableCell ID="FourofKindScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnFourKind" Text="Save" runat="server" OnClick="btnFourKind_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Full House</asp:TableCell>
                <asp:TableCell ID="fullHouseScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnFullHouse" Text="Save" runat="server" OnClick="btnFullHouse_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Small Straight</asp:TableCell>
                <asp:TableCell ID="smallStraightScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnSmallStraight" Text="Save" runat="server" OnClick="btnSmallStraight_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Large Straight</asp:TableCell>
                <asp:TableCell ID="largeStraightScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnLargeStraight" Text="Save" runat="server" OnClick="btnLargeStraight_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Yahtzee</asp:TableCell>
                <asp:TableCell ID="YahtzeeScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnYahtzee" Text="Save" runat="server" OnClick="btnYahtzee_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Chance</asp:TableCell>
                <asp:TableCell ID="chanceScoreValue"></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="btnChance" Text="Save" runat="server" OnClick="btnChance_Click" />
                </asp:TableCell>
            </asp:TableRow>
                 <asp:TableRow BackColor="#0066cc" ForeColor="White">
                <asp:TableCell>BONUS SECTION</asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
            <asp:TableCell>Upper Bonus</asp:TableCell>
            <asp:TableCell ID="upperBonusScoreValue"></asp:TableCell>
             
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Yahtzee Bonus</asp:TableCell>
            <asp:TableCell ID="yahtzeeBonusScoreValue"></asp:TableCell>
            <asp:TableCell>
                    <asp:Button ID="btnYahtzeeBonus" Text="Save" runat="server" OnClick="btnYahtzeeBonus_Click"/><!-- OnClick="btnYahtzeeBonus_Click" -->
                </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Total Score</asp:TableCell>
                <asp:TableCell ID="totalScore"></asp:TableCell>
             
            </asp:TableRow>
        </asp:Table>
    </div>

    

    <div id="RoundInfo" runat="server">
        <h1>Roll: </h1>
        <h1 id="RollNumber" runat="server"></h1>
        <h1>/3</h1>
        <br />
        <h1>Round: </h1>
        <h1 id="RoundNumber" runat="server"></h1>
        <h1>/13</h1>
    </div>

    <div style="width: 479px">
        <asp:Table runat="server" ID="tableYahtzee" ViewStateMode="Enabled" HorizontalAlign="Left">
            <asp:TableRow runat="server" ID="rowDice" BorderWidth="1px">
                <asp:TableCell runat="server" ID="cellDie1" BorderWidth="1px">
                    <asp:Image runat="server" ID="imgDie1" />
                </asp:TableCell>
                <asp:TableCell runat="server" ID="cellDie2" BorderWidth="1px">
                    <asp:Image runat="server" ID="imgDie2" />
                </asp:TableCell>
                <asp:TableCell runat="server" ID="cellDie3" BorderWidth="1px">
                    <asp:Image runat="server" ID="imgDie3" />
                </asp:TableCell>
                <asp:TableCell runat="server" ID="cellDie4" BorderWidth="1px">
                    <asp:Image runat="server" ID="imgDie4" />
                </asp:TableCell>
                <asp:TableCell runat="server" ID="cellDie5" BorderWidth="1px">
                    <asp:Image runat="server" ID="imgDie5" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" ID="rowSave" BorderWidth="1px" HorizontalAlign="Center" BackColor="White">
                <asp:TableCell runat="server" ID="cellChk1" >
                    <span>Save Die </span>
                    <asp:CheckBox runat="server" ID="chk1" value="NewRoll" />
                    <input type="hidden" id="fv1" name="fv1" value="<%=GetFieldFaceValue(0) %>" />
               </asp:TableCell>
                <asp:TableCell runat="server" ID="cellChk2">
                    <span>Save Die </span>
                    <asp:CheckBox runat="server" ID="chk2" />
                   <input type="hidden" id="fv2" name="fv2" value="<%=GetFieldFaceValue(1) %>" />
                </asp:TableCell>
                <asp:TableCell runat="server" ID="cellChk3">
                    <span>Save Die </span>
                    <asp:CheckBox runat="server" ID="chk3" />
                   <input type="hidden" id="fv3" name="fv3" value="<%=GetFieldFaceValue(2) %>" />
                 </asp:TableCell>
                <asp:TableCell runat="server" ID="cellChk4">
                    <span>Save Die </span>
                    <asp:CheckBox runat="server" ID="chk4" />
                    <input type="hidden" id="fv4" name="fv4" value="<%=GetFieldFaceValue(3) %>" />
               </asp:TableCell>
                <asp:TableCell runat="server" ID="cellChk5">
                    <span>Save Die </span>
                    <asp:CheckBox runat="server" ID="chk5" />
                    <input type="hidden" id="fv5" name="fv5" value="<%=GetFieldFaceValue(4) %>" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <asp:Label id="RollText" runat="server"></asp:Label>
        <asp:Button ID="btnRoll" class="Roll" Text="Roll" runat="server" OnClick="btnRoll_Click"  />
    </div>
   

    </div>

    <br /><br />

    <div id="FinalScore" runat="server">
        <br />
        <h1 id="highscoreValue" runat="server"></h1><br />
        <h1><span class="auto-style1"><strong>Your Final Score:</strong></span> </h1><h1 id="finalScoreValue" runat="server"></h1>
                <br /><br />
         <asp:Button ID="buttonRestartGame" class="NewGame" Text="Start New Game" runat="server"  onClick="buttonRestartGame_Click"/>

    </div>
   </asp:Content>
