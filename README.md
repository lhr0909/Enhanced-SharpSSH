Enhanced-SharpSSH
=================

This is a fork of the Enhanced version of SharpSSH by Ketul. The difference is that this version is built with an updated .NET framework and uses System.Security.Cryptograph module instead of Org.Mentalis.Security.Cryptography for encryption.

I am going to add some more features to this version, such as checking file existence, Recursively create directories, etc.

Currently the existent new features are: (compared to Ketul's build)

1. mkdir are now able to fill in the non-existent sub directories and will not throw exception if the folder exists or if subfolders do not exist.
2. there is an exists method to check file/folder existence (functionality implemented with sftp's ls command (GetFileList() method from Tamir's original build)).
3. renamed the delete methods to Rm, Rmdir (make it consistent with other functions)

Ketul's Blog:
http://ketulpatel.wordpress.com/2010/05/13/enhanced-sharpssh/