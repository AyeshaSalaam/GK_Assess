using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Tests;
using TestProject.Common.Attributes;
using TestProject.Common.Enums;

namespace TestProject.Tests.AndroidAppiumProject
{
	public class GKPart2 : IAndroidTest
	{
		public ExecutionResult Execute(AndroidTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 25000;
			
			 // 1. Reset App
			// Clear application data and restart (Auto-generated)
			boolResult = driver.TestProject().ResetApp();
			report.Step("Reset App", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Confirm 'Genres' is visible
			by = By.Id("com.example.android.uamp:id/title");
			boolResult = driver.TestProject().IsVisible(by);
			report.Step("Is 'Genres' visible?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Select 'Genres'
			by = By.Id("com.example.android.uamp:id/title");
			boolResult = driver.TestProject().Tap(by);
			report.Step("Tap 'Genres'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Confirm 'Jazz & Blues' is present
			by = By.XPath("//android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.support.v4.widget.DrawerLayout[1]/android.widget.RelativeLayout[1]/android.widget.FrameLayout[1]/android.widget.RelativeLayout[1]/android.widget.ListView[1]/android.widget.RelativeLayout[3]/android.widget.LinearLayout[1]/android.widget.TextView[1]");
			boolResult = driver.TestProject().IsPresent(by);
			report.Step("Is 'Jazz & Blues' present?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. Select 'Jazz & Blues'
			by = By.XPath("//android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.support.v4.widget.DrawerLayout[1]/android.widget.RelativeLayout[1]/android.widget.FrameLayout[1]/android.widget.RelativeLayout[1]/android.widget.ListView[1]/android.widget.RelativeLayout[3]/android.widget.LinearLayout[1]/android.widget.TextView[1]");
			boolResult = driver.TestProject().Tap(by);
			report.Step("Tap 'Jazz & Blues'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Confirm 'Play item' is clickable
			by = By.XPath("//android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.support.v4.widget.DrawerLayout[1]/android.widget.RelativeLayout[1]/android.widget.FrameLayout[1]/android.widget.RelativeLayout[1]/android.widget.ListView[1]/android.widget.RelativeLayout[1]/android.widget.ImageView[1]");
			boolResult = driver.TestProject().IsClickable(by);
			report.Step("Is 'Play item' clickable?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. Select 'Play item'
			by = By.XPath("//android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.widget.LinearLayout[1]/android.widget.FrameLayout[1]/android.support.v4.widget.DrawerLayout[1]/android.widget.RelativeLayout[1]/android.widget.FrameLayout[1]/android.widget.RelativeLayout[1]/android.widget.ListView[1]/android.widget.RelativeLayout[1]/android.widget.ImageView[1]");
			boolResult = driver.TestProject().Tap(by);
			report.Step("Tap 'Play item'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Confirm 'play or pause1' is clickable
			by = By.Id("com.example.android.uamp:id/play_pause");
			boolResult = driver.TestProject().IsClickable(by);
			report.Step("Is 'play or pause1' clickable?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Select 'play or pause1'
			by = By.Id("com.example.android.uamp:id/play_pause");
			boolResult = driver.TestProject().Tap(by);
			report.Step("Tap 'play or pause1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Select device back button
			boolResult = driver.TestProject().SendKeyEvent(4);
			report.Step("Send key event '4'", boolResult, TakeScreenshotConditionType.Failure);

            // 11. Select device back button
            boolResult = driver.TestProject().SendKeyEvent(4);
			report.Step("Send key event '4'", boolResult, TakeScreenshotConditionType.Failure);

            // 12. Select device back button to Exit app
            boolResult = driver.TestProject().SendKeyEvent(4);
			report.Step("Send key event '4'", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}