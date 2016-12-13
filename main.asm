
INCLUDE Irvine32.inc
	RandArrSize = 50
.data
	randArr sdword RandArrSize dup(?)
.code
	; fills randArr with values 0:EBX
	; expected EBX , +ve value 
	fillRandArr PROC 
		inc ebx
		call randomize ;activate the seed
		mov ecx,RandArrSize
		mov esi,0
		L1: ;the trick is the 3 instruction lines shown below
			mov eax,ebx
			call randomrange
			mov randArr[esi*4],eax
			inc esi
	   loop L1
		
		; print the RandArr content
		mov ecx,RandArrSize
		mov esi,0
		L2:
			mov eax,randArr[esi*4]
			call writeInt
			mov al,20h
			call writechar
			inc esi
		loop L2

		ret
	fillRandArr ENDP









	; MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN
main proc
	
	mov ebx,10 ;set the range 0 : 10
	call fillRandArr

	exit
main ENDP

END main