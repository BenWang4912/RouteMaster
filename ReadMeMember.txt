0708 �ѨM���D
[]Memberindex�����U�~��S���b�Y
[]�j�Y�K�w�]�Ϥ�
[]parthnre�j�M�\��
[]administrator�j�M�\��

0707
[]��@�@���Ҧ��\��
  1.[]login��O�޲z�� -- �p�G�i�H�n�J�T���Y��w
  2.[]�]�p�ۤv�b���޲z�������v���A�^�h����login
  
  []�ȱJ�٦�
    []�ҥαb��
    []�ѰO/���K�X
    []Iindex�j�M
    []���v -�u���޲z�̥i�H
    []login
    []logout

  []��O�޲z��
    []�ҥαb��
    []�ѰO/���K�X
    []Index�j�M
    []���v --�u���b��޲z�̥i�H
    []login
    []logout

(0706 11:30 �ثe�i�ױ���55%~60%)
7/6
[��]�����v������
[]������AdministratorLogin����
[]�ѰO�K�X
[]�ҥαb��o�e�H��
[]���U�|���S���U�~��
----------
(0705 09:00 �ثe�i�ױ���40%)
7/5
[��]��s�v����s�Ӥ[�A��O�Ӧh�ɶ�

----------
7/4
[]����MemberCRUD
[��]edit ���U�~��
[]edit��T�h��
[��]searchfunction 
[��]edit�Ϥ��s�imember�A���|���s�iMemberImage

----------
7/3 (�W�ǫe�󥿦^��-- RouteMaster.Models.Infra.Extensions�� public static RoomCreateDto ToDto(this RoomCreateVM vm)�ɦ^�hId = vm.Id,)
[]�T�{�U�\��B�@ 
[��]Register���W�ǹϤ� //�j�Y�K��require�����Ұ��D
    1.�W�ǹϤ�
    2.�x�s�ɦW
    3.�^�s��db �P�ɤ]�n�s��t�@�����A
[��]MemberImage/Name �令���\null -- �i���ժ�
[��]�[�Jjquery.ui��content��Ƨ��A�[jquery.js��Script��Ƨ��̭��h
[��]<link rel="stylesheet" href="~/Content//jquery-ui.css"> �[��layout

----------
7/1
[��]�سyLogin ViewPage

----------
6/30 
[��]�إ� Member-RegisterPage
[��]�s����RegisterPage
[��]�إ� Confirmpage
[��]�K�X����

*********************************
ppt���i�y�{: 
   *AdministratorLogin 
    1.login
    2.�ѰO�K�X
    3.�n�J�v�����~

   *�i�ܦU�j���\�઺�v������
    1.�v������������
   
   *�|���޲z
    1.�j�M
    2.�Ƨ�
    3.���v�޲z
    4.���U�b�� - �ҥαb��

   *AdministratorLogout
    
     

�w�����\��

1.Register
  []�ҥαb��--�߰ݲժ��޳N��!!! �వ�N��  
  [��]���\���U�|��
  [��]���U�ɷs�W�Ϥ�
 

2.Edit 06120049 []MemberImage�O�ۤ��w
  []�ק�|�����
  []�ק�Ϥ�


3.Delete(�]���R���|���A�R���\���ܧ󬰰��v�\��)
  []���v�\�� -- �g�\���|��IsSuspended�ܧ󬰥��}�q


4.Search
  [��]Index���j�M 


5.�n�J/�n�X/�ѰO�K�X
  [��]�n�J
  []�n�J-�n�J�T�����~
  []�n�J-�����H����
  []�n�X
  []�ѰO�K�X


--viewpage�����t�m

6.�v���޲z
  1.�ݩʺ��} -- https://learn.microsoft.com/zh-tw/dotnet/api/system.web.mvc.authorizeattribute?view=aspnet-mvc-5.2
  2.�ѦҺ��}:
     *https://dotblogs.com.tw/ricochen/2010/03/19/14113
     *https://ithelp.ithome.com.tw/articles/10308230
     *https://dotblogs.com.tw/JesperLai/2018/03/20/170705
     *https://ithelp.ithome.com.tw/questions/10193367
     *https://exfast.me/2016/07/c-asp-net-mvc5-inherit-authorizeattribute-to-implement-custom-validation/

  3.Filter:
     *https://dotblogs.com.tw/Jamis/2016/01/09/125624
     *https://ithelp.ithome.com.tw/articles/10206966
     *https://ithelp.ithome.com.tw/articles/10198206

�v�����@�k:
1.���g�@��public class xxxxxx : AuthorizeAttribute <== �~��
2.�A�мg�̭��� AuthorizeCore // protected override bool AuthorizeCore(HttpContextBase httpContext)


    **�v��������:
      0707�U�ȧ�ɶ���խ��Q��