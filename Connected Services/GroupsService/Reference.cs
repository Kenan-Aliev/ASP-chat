﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_chat.GroupsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="groups", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class groups : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Group_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Group_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.groups_users[] groups_usersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.messages[] messagesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Group_ID {
            get {
                return this.Group_IDField;
            }
            set {
                if ((this.Group_IDField.Equals(value) != true)) {
                    this.Group_IDField = value;
                    this.RaisePropertyChanged("Group_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Group_Name {
            get {
                return this.Group_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Group_NameField, value) != true)) {
                    this.Group_NameField = value;
                    this.RaisePropertyChanged("Group_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.groups_users[] groups_users {
            get {
                return this.groups_usersField;
            }
            set {
                if ((object.ReferenceEquals(this.groups_usersField, value) != true)) {
                    this.groups_usersField = value;
                    this.RaisePropertyChanged("groups_users");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.messages[] messages {
            get {
                return this.messagesField;
            }
            set {
                if ((object.ReferenceEquals(this.messagesField, value) != true)) {
                    this.messagesField = value;
                    this.RaisePropertyChanged("messages");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="groups_users", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class groups_users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Group_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Groups_Users_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.groups groupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.users usersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Group_ID {
            get {
                return this.Group_IDField;
            }
            set {
                if ((this.Group_IDField.Equals(value) != true)) {
                    this.Group_IDField = value;
                    this.RaisePropertyChanged("Group_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Groups_Users_ID {
            get {
                return this.Groups_Users_IDField;
            }
            set {
                if ((this.Groups_Users_IDField.Equals(value) != true)) {
                    this.Groups_Users_IDField = value;
                    this.RaisePropertyChanged("Groups_Users_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_ID {
            get {
                return this.User_IDField;
            }
            set {
                if ((this.User_IDField.Equals(value) != true)) {
                    this.User_IDField = value;
                    this.RaisePropertyChanged("User_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.groups groups {
            get {
                return this.groupsField;
            }
            set {
                if ((object.ReferenceEquals(this.groupsField, value) != true)) {
                    this.groupsField = value;
                    this.RaisePropertyChanged("groups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.users users {
            get {
                return this.usersField;
            }
            set {
                if ((object.ReferenceEquals(this.usersField, value) != true)) {
                    this.usersField = value;
                    this.RaisePropertyChanged("users");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="messages", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class messages : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Chat_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int From_UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string From_UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Group_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Message_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Send_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.chats chatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.groups groupsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.users usersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Chat_ID {
            get {
                return this.Chat_IDField;
            }
            set {
                if ((this.Chat_IDField.Equals(value) != true)) {
                    this.Chat_IDField = value;
                    this.RaisePropertyChanged("Chat_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int From_User {
            get {
                return this.From_UserField;
            }
            set {
                if ((this.From_UserField.Equals(value) != true)) {
                    this.From_UserField = value;
                    this.RaisePropertyChanged("From_User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string From_UserName {
            get {
                return this.From_UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.From_UserNameField, value) != true)) {
                    this.From_UserNameField = value;
                    this.RaisePropertyChanged("From_UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Group_ID {
            get {
                return this.Group_IDField;
            }
            set {
                if ((this.Group_IDField.Equals(value) != true)) {
                    this.Group_IDField = value;
                    this.RaisePropertyChanged("Group_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsRead {
            get {
                return this.IsReadField;
            }
            set {
                if ((this.IsReadField.Equals(value) != true)) {
                    this.IsReadField = value;
                    this.RaisePropertyChanged("IsRead");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Message_ID {
            get {
                return this.Message_IDField;
            }
            set {
                if ((this.Message_IDField.Equals(value) != true)) {
                    this.Message_IDField = value;
                    this.RaisePropertyChanged("Message_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Send_Date {
            get {
                return this.Send_DateField;
            }
            set {
                if ((this.Send_DateField.Equals(value) != true)) {
                    this.Send_DateField = value;
                    this.RaisePropertyChanged("Send_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.chats chats {
            get {
                return this.chatsField;
            }
            set {
                if ((object.ReferenceEquals(this.chatsField, value) != true)) {
                    this.chatsField = value;
                    this.RaisePropertyChanged("chats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.groups groups {
            get {
                return this.groupsField;
            }
            set {
                if ((object.ReferenceEquals(this.groupsField, value) != true)) {
                    this.groupsField = value;
                    this.RaisePropertyChanged("groups");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.users users {
            get {
                return this.usersField;
            }
            set {
                if ((object.ReferenceEquals(this.usersField, value) != true)) {
                    this.usersField = value;
                    this.RaisePropertyChanged("users");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="users", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Connection_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsOnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.chats[] chatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.chats[] chats1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.groups_users[] groups_usersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.messages[] messagesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Connection_Id {
            get {
                return this.Connection_IdField;
            }
            set {
                if ((object.ReferenceEquals(this.Connection_IdField, value) != true)) {
                    this.Connection_IdField = value;
                    this.RaisePropertyChanged("Connection_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsOnline {
            get {
                return this.IsOnlineField;
            }
            set {
                if ((this.IsOnlineField.Equals(value) != true)) {
                    this.IsOnlineField = value;
                    this.RaisePropertyChanged("IsOnline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_ID {
            get {
                return this.User_IDField;
            }
            set {
                if ((this.User_IDField.Equals(value) != true)) {
                    this.User_IDField = value;
                    this.RaisePropertyChanged("User_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.chats[] chats {
            get {
                return this.chatsField;
            }
            set {
                if ((object.ReferenceEquals(this.chatsField, value) != true)) {
                    this.chatsField = value;
                    this.RaisePropertyChanged("chats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.chats[] chats1 {
            get {
                return this.chats1Field;
            }
            set {
                if ((object.ReferenceEquals(this.chats1Field, value) != true)) {
                    this.chats1Field = value;
                    this.RaisePropertyChanged("chats1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.groups_users[] groups_users {
            get {
                return this.groups_usersField;
            }
            set {
                if ((object.ReferenceEquals(this.groups_usersField, value) != true)) {
                    this.groups_usersField = value;
                    this.RaisePropertyChanged("groups_users");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.messages[] messages {
            get {
                return this.messagesField;
            }
            set {
                if ((object.ReferenceEquals(this.messagesField, value) != true)) {
                    this.messagesField = value;
                    this.RaisePropertyChanged("messages");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="chats", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class chats : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Chat_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.messages[] messagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.users usersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASP_chat.GroupsService.users users1Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Chat_ID {
            get {
                return this.Chat_IDField;
            }
            set {
                if ((this.Chat_IDField.Equals(value) != true)) {
                    this.Chat_IDField = value;
                    this.RaisePropertyChanged("Chat_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_1 {
            get {
                return this.User_1Field;
            }
            set {
                if ((this.User_1Field.Equals(value) != true)) {
                    this.User_1Field = value;
                    this.RaisePropertyChanged("User_1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_2 {
            get {
                return this.User_2Field;
            }
            set {
                if ((this.User_2Field.Equals(value) != true)) {
                    this.User_2Field = value;
                    this.RaisePropertyChanged("User_2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.messages[] messages {
            get {
                return this.messagesField;
            }
            set {
                if ((object.ReferenceEquals(this.messagesField, value) != true)) {
                    this.messagesField = value;
                    this.RaisePropertyChanged("messages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.users users {
            get {
                return this.usersField;
            }
            set {
                if ((object.ReferenceEquals(this.usersField, value) != true)) {
                    this.usersField = value;
                    this.RaisePropertyChanged("users");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASP_chat.GroupsService.users users1 {
            get {
                return this.users1Field;
            }
            set {
                if ((object.ReferenceEquals(this.users1Field, value) != true)) {
                    this.users1Field = value;
                    this.RaisePropertyChanged("users1");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceError", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class ServiceError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((this.ErrorCodeField.Equals(value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GroupsService.IGroups")]
    public interface IGroups {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetUserGroups", ReplyAction="http://tempuri.org/IGroups/GetUserGroupsResponse")]
        ASP_chat.GroupsService.groups[] GetUserGroups(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetUserGroups", ReplyAction="http://tempuri.org/IGroups/GetUserGroupsResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.groups[]> GetUserGroupsAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/CreateNewGroup", ReplyAction="http://tempuri.org/IGroups/CreateNewGroupResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ASP_chat.GroupsService.ServiceError), Action="http://tempuri.org/IGroups/CreateNewGroupServiceErrorFault", Name="ServiceError", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
        ASP_chat.GroupsService.groups CreateNewGroup(int userId, string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/CreateNewGroup", ReplyAction="http://tempuri.org/IGroups/CreateNewGroupResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.groups> CreateNewGroupAsync(int userId, string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/SendMessage", ReplyAction="http://tempuri.org/IGroups/SendMessageResponse")]
        ASP_chat.GroupsService.messages SendMessage(int groupId, int fromUserId, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/SendMessage", ReplyAction="http://tempuri.org/IGroups/SendMessageResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.messages> SendMessageAsync(int groupId, int fromUserId, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetGroupMessages", ReplyAction="http://tempuri.org/IGroups/GetGroupMessagesResponse")]
        ASP_chat.GroupsService.messages[] GetGroupMessages(int groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetGroupMessages", ReplyAction="http://tempuri.org/IGroups/GetGroupMessagesResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.messages[]> GetGroupMessagesAsync(int groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/AddUserToGroup", ReplyAction="http://tempuri.org/IGroups/AddUserToGroupResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ASP_chat.GroupsService.ServiceError), Action="http://tempuri.org/IGroups/AddUserToGroupServiceErrorFault", Name="ServiceError", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
        ASP_chat.GroupsService.users AddUserToGroup(int userID, int groupID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/AddUserToGroup", ReplyAction="http://tempuri.org/IGroups/AddUserToGroupResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.users> AddUserToGroupAsync(int userID, int groupID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetGroupMembers", ReplyAction="http://tempuri.org/IGroups/GetGroupMembersResponse")]
        ASP_chat.GroupsService.users[] GetGroupMembers(int groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroups/GetGroupMembers", ReplyAction="http://tempuri.org/IGroups/GetGroupMembersResponse")]
        System.Threading.Tasks.Task<ASP_chat.GroupsService.users[]> GetGroupMembersAsync(int groupId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGroupsChannel : ASP_chat.GroupsService.IGroups, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupsClient : System.ServiceModel.ClientBase<ASP_chat.GroupsService.IGroups>, ASP_chat.GroupsService.IGroups {
        
        public GroupsClient() {
        }
        
        public GroupsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ASP_chat.GroupsService.groups[] GetUserGroups(int userID) {
            return base.Channel.GetUserGroups(userID);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.groups[]> GetUserGroupsAsync(int userID) {
            return base.Channel.GetUserGroupsAsync(userID);
        }
        
        public ASP_chat.GroupsService.groups CreateNewGroup(int userId, string groupName) {
            return base.Channel.CreateNewGroup(userId, groupName);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.groups> CreateNewGroupAsync(int userId, string groupName) {
            return base.Channel.CreateNewGroupAsync(userId, groupName);
        }
        
        public ASP_chat.GroupsService.messages SendMessage(int groupId, int fromUserId, string message) {
            return base.Channel.SendMessage(groupId, fromUserId, message);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.messages> SendMessageAsync(int groupId, int fromUserId, string message) {
            return base.Channel.SendMessageAsync(groupId, fromUserId, message);
        }
        
        public ASP_chat.GroupsService.messages[] GetGroupMessages(int groupId) {
            return base.Channel.GetGroupMessages(groupId);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.messages[]> GetGroupMessagesAsync(int groupId) {
            return base.Channel.GetGroupMessagesAsync(groupId);
        }
        
        public ASP_chat.GroupsService.users AddUserToGroup(int userID, int groupID) {
            return base.Channel.AddUserToGroup(userID, groupID);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.users> AddUserToGroupAsync(int userID, int groupID) {
            return base.Channel.AddUserToGroupAsync(userID, groupID);
        }
        
        public ASP_chat.GroupsService.users[] GetGroupMembers(int groupId) {
            return base.Channel.GetGroupMembers(groupId);
        }
        
        public System.Threading.Tasks.Task<ASP_chat.GroupsService.users[]> GetGroupMembersAsync(int groupId) {
            return base.Channel.GetGroupMembersAsync(groupId);
        }
    }
}
