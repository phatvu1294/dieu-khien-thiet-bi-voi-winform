/* Định nghĩa tần số thạch anh */
#define F_CPU 16000000ul

#include <avr/io.h>
unsigned char c;

int main(void)
{
	/**************************************************************************
	Cấu hình PORTC là là đầu ra và giá giá trị ban đầu PORTC = 0 (tắt toàn bộ)
	**************************************************************************/
	DDRC = 0xFF;
	PORTC = 0x00;

	/**************************************************************************
	+ TXEN = 1: Cho phép TX, TXEN = 0: vô hiệu hóa TX
	+ RXEN = 1: cho phép RX, RXEN = 0: vô hiệu hóa RX
	+ 3 Bit UCSZ
	UCSZ2  UCSZ1  UCSZ0  dataSize
	0      0      0      5
	0      0      0      6
	0      0      0      7
	0      0      0      8
	0      0      0      9
	+ UBRESL = 1: UCSRC được sử dụng, URSEL = 0: UBRRH được sử dụng
	+ UBRRL: Cài đặt tốc độ baud  
	UBRR = (Fosc / (16 * baud)) - 1
	Ví dụ: UBRR = (16000000 / (16 * 9600)) - 1 = 103 = 0x67
	**************************************************************************/
	UCSRB = (1 << TXEN) | (1 << RXEN);
	UCSRC = (1<< UCSZ1) | (1 << UCSZ0) | (1 << URSEL);
	UBRRL = 0x67;
	
	while(1)
	{
		/**************************************************************************
		Chờ cho đến khi bit RXC (nhận thành công) trong thanh ghi UCSRA = 1
		thì đọc dữ liệu UART
		**************************************************************************/
		while(!(UCSRA & (1 << RXC)));
		c = UDR;
		
		/**************************************************************************
		Đặt giá trị PORTC là byte vừa nhận được
		**************************************************************************/
		PORTC = c;
		
		/**************************************************************************
		Chờ cho đến khi bit UDRXE (dữ liệu rỗng) trong thanh ghi UCSRA = 1
		thì gửi dữ liệu phản hồi UART
		**************************************************************************/
		while (!(UCSRA & (1 << UDRE)));
		UDR = c;
	}
}


