// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeskBandServer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DeskBandServer.Grpc {

  /// <summary>Holder for reflection information generated from DeskBandServer.proto</summary>
  public static partial class DeskBandServerReflection {

    #region Descriptor
    /// <summary>File descriptor for DeskBandServer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeskBandServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChREZXNrQmFuZFNlcnZlci5wcm90bxITRGVza0JhbmRTZXJ2ZXIuR3JwYxoa",
            "U2VydmVySW5mcmFzdHJ1Y3R1cmUucHJvdG8iEAoOR2V0U2l6ZVJlcXVlc3Qi",
            "LQoMR2V0U2l6ZVJlcGx5Eg0KBVdpZHRoGAEgASgFEg4KBkhlaWdodBgCIAEo",
            "BSJuChZTaG93VGV4dE1lc3NhZ2VSZXF1ZXN0Eg0KBU1zZ0lEGAEgASgJEg8K",
            "B0NvbnRlbnQYAiABKAkSNAoKRm9yZWdyb3VuZBgDIAEoCzIgLkRlc2tCYW5k",
            "U2VydmVyLkdycGMuQ3VzdG9tQ29sb3IiJQoUU2hvd1RleHRNZXNzYWdlUmVw",
            "bHkSDQoFTXNnSUQYASABKAkyzwEKD0Rlc2tCYW5kU2VydmljZRJRCgdHZXRT",
            "aXplEiMuRGVza0JhbmRTZXJ2ZXIuR3JwYy5HZXRTaXplUmVxdWVzdBohLkRl",
            "c2tCYW5kU2VydmVyLkdycGMuR2V0U2l6ZVJlcGx5EmkKD1Nob3dUZXh0TWVz",
            "c2FnZRIrLkRlc2tCYW5kU2VydmVyLkdycGMuU2hvd1RleHRNZXNzYWdlUmVx",
            "dWVzdBopLkRlc2tCYW5kU2VydmVyLkdycGMuU2hvd1RleHRNZXNzYWdlUmVw",
            "bHliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DeskBandServer.Grpc.ServerInfrastructureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DeskBandServer.Grpc.GetSizeRequest), global::DeskBandServer.Grpc.GetSizeRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DeskBandServer.Grpc.GetSizeReply), global::DeskBandServer.Grpc.GetSizeReply.Parser, new[]{ "Width", "Height" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DeskBandServer.Grpc.ShowTextMessageRequest), global::DeskBandServer.Grpc.ShowTextMessageRequest.Parser, new[]{ "MsgID", "Content", "Foreground" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DeskBandServer.Grpc.ShowTextMessageReply), global::DeskBandServer.Grpc.ShowTextMessageReply.Parser, new[]{ "MsgID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetSizeRequest : pb::IMessage<GetSizeRequest> {
    private static readonly pb::MessageParser<GetSizeRequest> _parser = new pb::MessageParser<GetSizeRequest>(() => new GetSizeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetSizeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DeskBandServer.Grpc.DeskBandServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeRequest(GetSizeRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeRequest Clone() {
      return new GetSizeRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetSizeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetSizeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetSizeRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class GetSizeReply : pb::IMessage<GetSizeReply> {
    private static readonly pb::MessageParser<GetSizeReply> _parser = new pb::MessageParser<GetSizeReply>(() => new GetSizeReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetSizeReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DeskBandServer.Grpc.DeskBandServerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeReply(GetSizeReply other) : this() {
      width_ = other.width_;
      height_ = other.height_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSizeReply Clone() {
      return new GetSizeReply(this);
    }

    /// <summary>Field number for the "Width" field.</summary>
    public const int WidthFieldNumber = 1;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "Height" field.</summary>
    public const int HeightFieldNumber = 2;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetSizeReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetSizeReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Width != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Height);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetSizeReply other) {
      if (other == null) {
        return;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Width = input.ReadInt32();
            break;
          }
          case 16: {
            Height = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ShowTextMessageRequest : pb::IMessage<ShowTextMessageRequest> {
    private static readonly pb::MessageParser<ShowTextMessageRequest> _parser = new pb::MessageParser<ShowTextMessageRequest>(() => new ShowTextMessageRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ShowTextMessageRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DeskBandServer.Grpc.DeskBandServerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageRequest(ShowTextMessageRequest other) : this() {
      msgID_ = other.msgID_;
      content_ = other.content_;
      foreground_ = other.foreground_ != null ? other.foreground_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageRequest Clone() {
      return new ShowTextMessageRequest(this);
    }

    /// <summary>Field number for the "MsgID" field.</summary>
    public const int MsgIDFieldNumber = 1;
    private string msgID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgID {
      get { return msgID_; }
      set {
        msgID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Content" field.</summary>
    public const int ContentFieldNumber = 2;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Foreground" field.</summary>
    public const int ForegroundFieldNumber = 3;
    private global::DeskBandServer.Grpc.CustomColor foreground_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::DeskBandServer.Grpc.CustomColor Foreground {
      get { return foreground_; }
      set {
        foreground_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ShowTextMessageRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ShowTextMessageRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgID != other.MsgID) return false;
      if (Content != other.Content) return false;
      if (!object.Equals(Foreground, other.Foreground)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgID.Length != 0) hash ^= MsgID.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (foreground_ != null) hash ^= Foreground.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MsgID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MsgID);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Content);
      }
      if (foreground_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Foreground);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MsgID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgID);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (foreground_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Foreground);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ShowTextMessageRequest other) {
      if (other == null) {
        return;
      }
      if (other.MsgID.Length != 0) {
        MsgID = other.MsgID;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.foreground_ != null) {
        if (foreground_ == null) {
          Foreground = new global::DeskBandServer.Grpc.CustomColor();
        }
        Foreground.MergeFrom(other.Foreground);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MsgID = input.ReadString();
            break;
          }
          case 18: {
            Content = input.ReadString();
            break;
          }
          case 26: {
            if (foreground_ == null) {
              Foreground = new global::DeskBandServer.Grpc.CustomColor();
            }
            input.ReadMessage(Foreground);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ShowTextMessageReply : pb::IMessage<ShowTextMessageReply> {
    private static readonly pb::MessageParser<ShowTextMessageReply> _parser = new pb::MessageParser<ShowTextMessageReply>(() => new ShowTextMessageReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ShowTextMessageReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DeskBandServer.Grpc.DeskBandServerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageReply(ShowTextMessageReply other) : this() {
      msgID_ = other.msgID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShowTextMessageReply Clone() {
      return new ShowTextMessageReply(this);
    }

    /// <summary>Field number for the "MsgID" field.</summary>
    public const int MsgIDFieldNumber = 1;
    private string msgID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgID {
      get { return msgID_; }
      set {
        msgID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ShowTextMessageReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ShowTextMessageReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgID != other.MsgID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgID.Length != 0) hash ^= MsgID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MsgID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MsgID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MsgID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ShowTextMessageReply other) {
      if (other == null) {
        return;
      }
      if (other.MsgID.Length != 0) {
        MsgID = other.MsgID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MsgID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code