
5. File Upload


	1. a.jpg                ----> data/1/[1]a.jpg (x)
	2. b.jpg, c.jpg         ----> data/1/[2]b.jpg
				             ----> data/2/[2]c.jpg

	3. a.jpg                ------> data/1/[3]a.jpg 
	4. a.jpg                ------> data/1/[4]a.jpg
	5. a.jpg                ------> data/1/[5]a.jpg
	6. a.jpg                ------> data/1/[6]a.jpg

	3327. a.jpg             ------> data/1/[3327]a.jpg

									data/�Խ��ǹ�ȣ/1/37/a.jpg

4. Board

gid, thread
select * from board where bid='1' order by notice desc, gid desc, thread asc limit $start, 10;
1, 2, 3, 4,

page
start = (page -1) * 10
						gid	notice
9. ���� 2						5	1
8. ���� 1						4	1


18. ������ ��					7	0
10. ���ο� ���Դϴ�.					6
5. Good Morning					3
     6. Re : Good Morning				3
2. Hello						2
     7. Re : Hello					2
1. �ȳ��ϼ���.					1	A
    3. Re : �ȳ��ϼ���				1	AA	
  	11. Re : Re : �ȳ��ϼ���.			1	AAA
	13.  Re : Re : �ȳ��ϼ���.			1	AAB
		15. Re :  Re : Re : �ȳ��ϼ���.		1	AABA
		17. Re :  Re : Re : �ȳ��ϼ���.		1	AABB
							AABBA
							AABBB
							AABBC
	14.  Re : Re : �ȳ��ϼ���.			1	AAC
	16. Re : Re : �ȳ��ϼ���.			1	AAD
    4. Re : �ȳ��ϼ���.				1	AB
    12. Re : �ȳ��ϼ���.				1	AC

3. NuGet Package ��ġ

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

1. HTML�� Error �ڵ�

	1xx : Trying

	2xx : OK
	3xx : Redirect Error, Temporary Error
	4xx : Client Error, Permanent Error
	5xx : Server Error
	6xx : Global Error

	enum errorcode { "Trying" = 100, "OK" = 200, 
						"BadRequest"=400, "UnAuthorized", "Payment", "Forbidden", "NotFound", "MethodNotAllowed" }