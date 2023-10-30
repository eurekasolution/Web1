

1. HTMLÀÇ Error ÄÚµå

	1xx : Trying

	2xx : OK
	3xx : Redirect Error, Temporary Error
	4xx : Client Error, Permanent Error
	5xx : Server Error
	6xx : Global Error

	enum errorcode { "Trying" = 100, "OK" = 200, 
						"BadRequest"=400, "UnAuthorized", "Payment", "Forbidden", "NotFound", "MethodNotAllowed" }