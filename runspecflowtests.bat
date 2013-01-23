@echo off
"C:\Program Files (x86)\NUnit 2.5.10\bin\net-2.0\nunit-console.exe" %1
"C:\Program Files (x86)\TechTalk\SpecFlow\specflow.exe" nunitexecutionreport %2 /xmlTestResult:%3
if NOT %errorlevel% == 0 (
echo "Error generating report - %errorlevel%"
GOTO :exit
)
if %errorlevel% ==0 TestResult.html
:exit