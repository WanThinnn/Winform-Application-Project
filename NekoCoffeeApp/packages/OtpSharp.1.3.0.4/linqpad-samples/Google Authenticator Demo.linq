<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <NuGetReference>Base32</NuGetReference>
  <NuGetReference>OtpSharp</NuGetReference>
  <Namespace>OtpSharp</Namespace>
  <Namespace>System.Web</Namespace>
</Query>

/* Scan the following QR code with the Google authenticator app.
 * Make sure the clock on your computer and your smartphone are in sync.
 * 
 * The code that is generated should match what is on your smartphone.
 */
 
var url = "otpauth://totp/linqpad@test.com?secret=AEBAGBAFAYDQQCIAAEBAGBAFAYDQQCIAAEBAGBAFAYDQQCIA";
var totp = (Totp)KeyUrl.FromUrl(url);

var qrCodeUrl = string.Format("http://qrcode.kaywa.com/img.php?s=4&d={0}", HttpUtility.UrlEncode(url));

Util.Image(qrCodeUrl).Dump();

totp.ComputeTotp().Dump("Timed One Time Password");
totp.RemainingSeconds().Dump("Remaining seconds");