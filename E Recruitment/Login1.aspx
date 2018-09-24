<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs"  theme="Theme1" Inherits="E_Recruitment.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <script src="http://code.jquery.com/jquery-1.8.2.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $('.menu ul li').hover(
        function () {
            $('.sub_menu', this).stop(true, true).slideDown(); /*slideDown the subitems on mouseover*/
        }, function () {
            $('.sub_menu', this).stop(true, true).slideUp();  /*slideUp the subitems on mouseout*/
        });
    });
    var slideimages = new Array() // create new array to preload images
    slideimages[0] = new Image() // create new instance of image object
    slideimages[0].src = "image/images.jpg" // set image src property to image path, preloading image in the process
    slideimages[1] = new Image()
    slideimages[1].src = "image/imgg.jpg"
    slideimages[2] = new Image()
    slideimages[2].src = "image/0.jpg"
    slideimages[3] = new Image()
    slideimages[3].src = "image/1.jpg"
    slideimages[4] = new Image()
    slideimages[4].src = "image/11.jpg"
    slideimages[5] = new Image()
    slideimages[5].src = "image/8.jpg"
    slideimages[6] = new Image()
    slideimages[6].src = "image/4.jpg"
    slideimages[7] = new Image()
    slideimages[7].src = "image/2.jpg"
    var step = 0


    //var image1 = new Image()
    //image1.src = "image/images.jpg"
    //var image2 = new Image()
    //image2.src = "image/back.jpg"

</script>
    <style type="text/css">
         .menu{
width:100%;
font-family: verdana, Segoe UI;
background-color:#B34C00;
margin:0 auto;
height:38px;
border: 1px solid #B34C00;
border-radius: 4px; /*To make the corners rounded in IE*/
-moz-border-radius: 4px; /*this is for mozilla*/
-webkit-border-radius: 4px; /*chrome and other browsers*/
box-shadow: 0 1px 1px #dddddd inset;
-moz-box-shadow: 0 1px 1px #dddddd inset;
-webkit-box-shadow: 0 1px 1px #dddddd inset;
}
.menu ul{
padding:0px;
margin: 0px;
list-style: none;
        width: 804px;
        height: 59px;
    }
.menu ul li{
display: inline-block;
float:left;
position: relative;
        top: 0px;
        left: 96px;
        width: 244px;
            height: 40px;
        }
.menu ul li a{
color:#ffffff;
text-decoration: none;
display: block;
padding:10px 15px;
}
.menu ul li a:hover{
background-color: #666666;
}
.sub_menu{
position: absolute;
background-color: #666666;
width:300px;
top:38px;
left:0px;
display:none; /*hide the subitems div tag initially*/
border-bottom:4px solid #B34C00; /*just to add a little more good look*/
}
.sub_menu ul li{
width:100px;
}
.sub_menu ul li a{
color:#ffffff;
text-decoration: none;
display: block;
padding:10px 15px;
}
.sub_items ul li a:hover{
background-color: #777777;
}
        .auto-style1 {
            width: 146px;
            height: 84px;
        }
                        body {
    background-color: 	#0066CC;
            height: 527px;
            width: 1227px;
        }
                    #slide {
            width: 787px;
            height: 223px;
        }
        .slider_H{
            margin-left:0%;
           
        }
        .image_h{
            width:100%;
            margin-left:10%;

        }
    </style>

</head>
<body>
      <form id="form1" runat="server">
    <div style="height: 600px; width:80%; margin-left:19%; margin-right:10%; border-radius:10px; border-style:solid; background-color:white">
        <asp:Panel ID="Panel2" runat="server" Height="500px" BackColor="White" style="margin-left:10%; margin-right:10%"  Width="80%">     
            <img alt="" class="auto-style1" src="image/logo.jpg" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#0066CC" Text="J-HASH Consultancy Services"></asp:Label>
          
 <%--<div class="menu">
 <asp:Panel ID="Panel1" runat="server">
<ul>
<li><a href="#">Home</a></li>
<li><a href="#">AboutUs</a></li>
<li><a href="#">ContactUs</a>
</ul>
 </asp:Panel>
</div>--%>
 <div>
                <asp:Panel ID="Panel5" runat="server" Width="100%"  Height="223px" BorderStyle="Inset" CssClass="slider_H" >
                    <img src="image/images.jpg" id="slide" />
                         </asp:Panel>
                    <script type="text/javascript">

                        function slideit() {
                            //if browser does not support the image object, exit.
                            if (!document.images)
                                return
                            document.getElementById('slide').src = slideimages[step].src
                            if (step < 6)
                                step++
                            else
                                step = 0
                            //call function "slideit()" every 2.5 seconds
                            setTimeout("slideit()", 1900)
                        }
                        slideit()
           </script>
                    </div>           
            <div>
        <asp:Panel ID="pan1" runat="server" CssClass="login" HorizontalAlign="Left" >
        <asp:Table ID="Table1" runat="server" Height="118px" Width="787px" style="margin-left: 5px">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="Login" ForeColor="#660033" Font-Size="XX-Large"></asp:Label>
                </asp:TableCell>
               
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Right">
                    <asp:Label ID="lblusid" runat="server" Text="User ID" ></asp:Label>
                    <br/>
                    <br/>
                    <asp:Label ID="lblpwd" runat="server" Text="Password"></asp:Label>
                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Left">
                    <asp:TextBox ID="txtusid" runat="server" TextMode="SingleLine"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RfvUsername" runat="server" ControlToValidate="txtusid" ErrorMessage="Please enter UserID" ForeColor="Red"></asp:RequiredFieldValidator>
                     <br />
                    <br />
                    <asp:RequiredFieldValidator ID="RfvPassword" runat="server" ControlToValidate="txtpwd" ErrorMessage="Please enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
               </asp:TableCell>
           </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>

                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Center">
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                </asp:TableCell>
              

                
            </asp:TableRow >
           
              </asp:Table>
            
            &nbsp;</asp:Panel>
            </div>
            </asp:Panel> 
            </div>
     
    </form>    
    </body>
</html>
