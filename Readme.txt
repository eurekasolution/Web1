9. 

	JS :

	function sayHello()
	{
	
	}

	function test(value)
	{
	
	}

	sayHello = () => { };

	int value = (x) => { x * x };
	int value = (x) => x * x;

	int value = (x, y) => { x + y };
	int value = (x, y) => x + y;

	int value = (x, y) => {
		let sum = x + y;
		return sum;
	};

	int value = add(x , y);
	function add(a, b)
	{
		return a + b;
	}

	function noName(x)
	{
		return x * x;
	}

	int value = noName(x);


	test((x, y) => x + y);


8. 2월

	year
	29 : 4의 배수이면서, 100으로는 안떨어지고 400으로 나누어떨어지면 29이다.


	if(year % 4 == 0)
	{
		// 기본 : 29

		if(year % 100==0)
		{ 
			// 28 ( 1900 )
			if(year % 400 ==0)
				// 29
			else
				// 28
		}else
		{
			29
		}
	}else
	{
		28
	}

7. Migrations

	dotnet ef migrations add init
	dotnet ef database update
6. 통신기술

	TDMA
	FDMA
	CDMA


5. File Upload


	1. a.jpg                ----> data/1/[1]a.jpg (x)
	2. b.jpg, c.jpg         ----> data/1/[2]b.jpg
				             ----> data/2/[2]c.jpg

	3. a.jpg                ------> data/1/[3]a.jpg 
	4. a.jpg                ------> data/1/[4]a.jpg
	5. a.jpg                ------> data/1/[5]a.jpg
	6. a.jpg                ------> data/1/[6]a.jpg

	3327. a.jpg             ------> data/1/[3327]a.jpg

									data/게시판번호/1/37/a.jpg

4. Board

gid, thread
select * from board where bid='1' order by notice desc, gid desc, thread asc limit $start, 10;
1, 2, 3, 4,

page
start = (page -1) * 10
						gid	notice
9. 공지 2						5	1
8. 공지 1						4	1


18. 마지막 글					7	0
10. 새로운 글입니다.					6
5. Good Morning					3
     6. Re : Good Morning				3
2. Hello						2
     7. Re : Hello					2
1. 안녕하세요.					1	A
    3. Re : 안녕하세요				1	AA	
  	11. Re : Re : 안녕하세요.			1	AAA
	13.  Re : Re : 안녕하세요.			1	AAB
		15. Re :  Re : Re : 안녕하세요.		1	AABA
		17. Re :  Re : Re : 안녕하세요.		1	AABB
							AABBA
							AABBB
							AABBC
	14.  Re : Re : 안녕하세요.			1	AAC
	16. Re : Re : 안녕하세요.			1	AAD
    4. Re : 안녕하세요.				1	AB
    12. Re : 안녕하세요.				1	AC

3. NuGet Package 설치

	Pomelo.EntityFrameworkCore.MySql
	Microsoft.EntityFrameworkCore
	Microsoft.EntityFrameworkCore.Design


	cmd 
		dotnet tool install --global dotnet-ef

		dotnet ef migrations add init


2. foreach

	Java :  for(int value : myArray)
			{
				// value
			}
	C# : foreach(int value in myArray)

1. HTML의 Error 코드

	1xx : Trying

	2xx : OK
	3xx : Redirect Error, Temporary Error
	4xx : Client Error, Permanent Error
	5xx : Server Error
	6xx : Global Error

	enum errorcode { "Trying" = 100, "OK" = 200, 
						"BadRequest"=400, "UnAuthorized", "Payment", "Forbidden", "NotFound", "MethodNotAllowed" }