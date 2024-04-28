<Query Kind="Statements">
  <NuGetReference>Base32</NuGetReference>
  <NuGetReference>OtpSharp</NuGetReference>
  <Namespace>OtpSharp</Namespace>
</Query>

var url = "otpauth://totp/linqpad@test.com?secret=AEBAGBAFAYDQQCIAAEBAGBAFAYDQQCIAAEBAGBAFAYDQQCIA";
var totp = (Totp)KeyUrl.FromUrl(url);

totp.ComputeTotp().Dump("Timed One Time Password");
totp.RemainingSeconds().Dump("Remaining seconds");