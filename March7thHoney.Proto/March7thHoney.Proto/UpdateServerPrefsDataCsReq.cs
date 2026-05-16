using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateServerPrefsDataCsReq : IMessage<UpdateServerPrefsDataCsReq>, IMessage, IEquatable<UpdateServerPrefsDataCsReq>, IDeepCloneable<UpdateServerPrefsDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateServerPrefsDataCsReq> _parser = new MessageParser<UpdateServerPrefsDataCsReq>(() => new UpdateServerPrefsDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ServerPrefsFieldNumber = 13;

	private ServerPrefs serverPrefs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateServerPrefsDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateServerPrefsDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerPrefs ServerPrefs
	{
		get
		{
			return serverPrefs_;
		}
		set
		{
			serverPrefs_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateServerPrefsDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateServerPrefsDataCsReq(UpdateServerPrefsDataCsReq other)
		: this()
	{
		serverPrefs_ = ((other.serverPrefs_ != null) ? other.serverPrefs_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateServerPrefsDataCsReq Clone()
	{
		return new UpdateServerPrefsDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateServerPrefsDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateServerPrefsDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ServerPrefs, other.ServerPrefs))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (serverPrefs_ != null)
		{
			num ^= ServerPrefs.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (serverPrefs_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ServerPrefs);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (serverPrefs_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ServerPrefs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateServerPrefsDataCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.serverPrefs_ != null)
		{
			if (serverPrefs_ == null)
			{
				ServerPrefs = new ServerPrefs();
			}
			ServerPrefs.MergeFrom(other.ServerPrefs);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (serverPrefs_ == null)
			{
				ServerPrefs = new ServerPrefs();
			}
			input.ReadMessage(ServerPrefs);
		}
	}
}
