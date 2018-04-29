\ 1.fs

: One
	0 
	1000 3 DO
		i 5 mod 0= i 3 mod 0= or IF	
			i +
		ENDIF
	LOOP
;
