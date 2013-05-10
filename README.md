Demonstrates an example of async DB logging with NLog and SQL Server in an ASP.NET MVC project.<br>
Also demonstrates error handling and reporting without using third party libraries like ELMAH.

Logging
==============
See Infrastructure\Diagnostics\ for logging and diagnostic info gathering classes.<br>
See configuration/nlog section of web.config for log configruation as well as transforms.<br>
See DB folder for SQL Server DB scripts.<br>
See usages in HomeController, ErrorController, ActionTrackerAttribute and other locations.<br>
Generate batch log statements from home page.

Error Handling
==============
See Infrastructure\ErrorHandling\, Global.asax.cs, ErrorController, Views\Shared\Error.cshtml<br>
See configuration\emailSettings in web.config for error report email settings<br>
Generate test errors and responses from home page