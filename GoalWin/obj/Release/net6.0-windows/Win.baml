   M S B A M L   `   `   `  ���� B  >GoalWin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GoalWinGoalWin      GoalWin.Win   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:GoalWin     -     �Name$  Window�� � Title$ 
MainWindow��$	��620��$
��1200�����	#FFDE7575 � 
ResizeMode$ CanMinimize=�.��� -    �Name$
 Main��.+��� $
��Auto=�$��	36,36,0,0q�$	��Top=�$
��Left=�.��� -   $ Ggrid��$��0q�$	��242�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+�(  "System.Windows.Controls.DatePicker  -     Name$ GDate��$��2��$��Center=�$��66,10,66,10q�
���   ���Z� �� -    ��Name$
 Gsum��$��Summit Goal��$��5��$��61,15,61,15q����	#FF13DC13$
��Bold"�$��30��$	��120����Z� �� -    ��Name$ Glable��$��0��$	��Top=�$��Setting Up A Goal��$��33,13,33,13q����	#FF00FF12$
��Bold"�$��20(���Z� �� -    ��Name$
 Grec�����	#FF1BBCAD	 K� ZIndex$	 -1��
 �� RadiusX$
 30�� �� RadiusY$ 30��$��0,0,0,0q�$��7���� -    ��Name$ Gname��$��1��$��10,11,10,15q�$��15(�$	��Top=� �� TextWrapping$
 Wrap=���Z� .������  �� 
TargetType" �� �� 	Resources    WatermarkBrush �� Opacity j� Stretch !� Visual��%m   &	        !� $	 0.5Q�$
 None=� �� $��Add A Title To Your Goal��$��Italic$�
���   �$��18(� �� Triggers P�  P� Property � �� P� Value$  ��. ���  �� Property � �� �� Value# [  P�  �@J�IsKeyboardFocused$
 True��. ���  � ��
 �����.���� -	   $ Gnote��$��3��$	��Top=�$��10,15,10,20q�$
 Wrap=�$��15(���Z� .������ " �� ��%z   &	        !� $	 0.5Q�$
 none=� �� $ ��Extra Notes To Pursue Goal��$��Italic$�
���   �$��18(�$
��Wrap=� P�  � ��$  ��. ���  � ��# [  P�  �@J�IsKeyboardFocused$
 True��. ���  � ��
 �����.���� -
   $
 Gpry��$��4��$	��Top=�$��10,20,10,17q�$
 Wrap=�$��15(���Z� .������ " �� ��%{   &	        !� $	 0.5Q�$
 none=� �� $!��Add Goal Priority If Needed��$��Italic$�
���   �$��18(�$
��Wrap=� P�  � ��$  ��. ���  � ��# [  P�  �@J�IsKeyboardFocused$
 True��. ���  � ��
 �����.���� -    ��Name$ GInputState��$��Center=�$��6��$��	0,15,0,15q�$
��Wrap=�$�� ��$	��Top=�$	��200��$��45��$��15(�$
��Bold"� �� TextAlignment$ Center=�� -   $ Gshow��$��	0,36,36,0q�$	��Top=�$��Right=�$	��361��$	��470��.+��� -   $ 	Gpoperror��$��Center=�$��	0,465,0,0q�$
��Wrap=�$�� ��$	��Top=�$	��200��$��45��$��15(�$
��Bold"�$ Center=��� -   $ lable��$��Current Goals��$��111,16,111,0q����	#FF00FF12$
��Bold"�$��20(�$	��Top=���Z� �� -   $	 rec�����	#FF1BBCAD$	 -1��$
 30��$ 30��$��0,0,0,0q��� -    ��Name$ Gcurrent�����	#FFD893E3$	��229��$��
38,74,38,0q�$	��Top=���Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $��5q����� *Name+�� $��5q����� *Date+�� $��5q����� *Notes+�� $��5q����� *Pri+�� $��5q����� *	Session+�� $��5q����� *Break+�� -   $
 Gdel��$��Delete Goal��$��Center=�$��	0,402,0,0q�$	��Top=����	#FFF72A2A
���   �$
��Bold"�$��23(�$��42��$	��286���� -   $ GStart��$��Start Current Goal��$��Center=�$��	0,330,0,0q�$	��Top=�
���   �$
��Bold"�$��23(�$��42��$	��286�����	#FF13DC13��Z� � -   $
 time��$��328,36,630,0q�$	��Top=�$	��146��.+��� -   $
 trec�����	#FF1BBCAD$	 -1��$
 30��$ 30��$��0,0,0,0q��� -   $ tlabel��$(��"Set Work Sessions And Breaks (Min)�����	#FF00FF12$
��Bold"�$��20(�$ Center=�$
��Wrap=�$	��Top=�$��55��$��
16,10,16,0q���Z� �� -   $ Gsession��$��
10,0,10,52q�$��15(�$��Bottom=�$
 Wrap=���Z� .������ " �� ��%j   &	        !� $	 0.5Q�$
 None=� �� $��Add Work Session Time��$��Italic$�
���   �$��18(� P�  � ��$  ��. ���  � ��# [  P�  �@J�IsKeyboardFocused$
 True��. ���  � ��
 �����.���� -   $ Gbreak��$��10,111,10,0q�$��15(�$	��Top=�$
 Wrap=�$��25����Z� .������ " �� ��%c   &	        !� $	 0.5Q�$
 None=� �� $��Add Break Time��$��Italic$�
���   �$��18(� P�  � ��$  ��. ���  � ��# [  P�  �@J�IsKeyboardFocused$
 True��. ���  � ��
 �����.��