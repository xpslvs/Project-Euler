\ 2.fs

: Two
	0 1
	4000000 2 DO
		i 1 and 0= IF
			swap i + swap	
		ENDIF
	i swap +LOOP
	drop	
;
