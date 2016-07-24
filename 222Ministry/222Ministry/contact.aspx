<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="_222Ministry.contact" %>

<!DOCTYPE html>
<html lang="en">

<head>
<!--
   222 Ministries Home
   Author: Angela Reid
   Date:   11/19/15

   Filename:         222main.aspx
   Supporting files: 222Basic.css
-->

<title>222 Ministries</title>
<!--[if lt IE 9]>
   <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
   <![endif]-->

<link rel="stylesheet" type="text/css" href="222Basic.css" />   
    <style type="text/css">
        .fb-page {
            width: 670px;
        }
    </style>
</head>
    <body>
        <!--Facebook Page JavaScript SDK  -->
        <div id="fb-root"></div>
            <script>(function(d, s, id) {
             var js, fjs = d.getElementsByTagName(s)[0];
              if (d.getElementById(id)) return;
                 js = d.createElement(s); js.id = id;
                 js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.6&appId={APP_ID}";
                 fjs.parentNode.insertBefore(js, fjs);
                }(document, 'script', 'facebook-jssdk'));
            </script>

    <div id ='header'>    
    </div>    
   <div id='cssmenu'>
        <ul>
              <li><a href='Default.aspx'><span>Home</span></a></li>
              <li><a href='Ministry.aspx'><span>Our Ministry</span></a></li>
              <li><a href='Training.aspx'><span>Training</span></a></li>
              <li><a href='Notes.aspx'><span>Ministry Notes</span></a></li>
              <li class='last'><a href='Contact.aspx'><span>Contact Us</span></a></li>
        </ul>
    </div>
    
    <div>
          
<h4>Partnership with 222 Ministries</h4>
<p>You can help build bridges between God and people, and create opportunities for spiritual multiplication. We invite you to partner with us through your prayers and financial giving.
 
You may financially support our mission by sending a tax-deductible gift  payable to 222 Ministries. </p></div>
 
 <a name="2b601bee-0ab1-45c1-8ff2-bed0c68197a2"></a>

  <div id="footerContent"><a id="paypalDonate" href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&amp;hosted_button_id=5237036"><img id="payPalImage" alt="Donate to 222-ministries.org" border="0" src="https://www.paypal.com/en_US/i/btn/btn_donateCC_LG.gif" /></a> <br />
<p>222 Ministries <br />
 600 South Jefferson Street <br />
 Brownsburg, IN 46112 <br /> <br />
 317-431-3027 <br />
 222ministries@sbcglobal.net <br />
 www.222-minisries.org
</p>
  </div> 
         
<!--Facebook Page plugin  -->
        
<div class="fb-page" 
  data-href="https://www.facebook.com/facebook"
  data-tabs="timeline" data-small-header="false" 
  data-adapt-container-width="true" data-hide-cover="false" 
  data-show-facepile="true">
   <blockquote cite="https://www.facebook.com/facebook" style="width: 236px; height: 56px;"
      class="fb-xfbml-parse-ignore" >        
      <img src="images/asset_f_logo_lg.png" style="height: 50px; width: 45px"/>
        <a href="https://www.facebook.com/facebook">Facebook</a>
    </blockquote>  
</div>
       
</body>
</html>
