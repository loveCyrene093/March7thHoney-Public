using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetAllowOtherApplyFriendCsReq : IMessage<SetAllowOtherApplyFriendCsReq>, IMessage, IEquatable<SetAllowOtherApplyFriendCsReq>, IDeepCloneable<SetAllowOtherApplyFriendCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetAllowOtherApplyFriendCsReq> _parser = new MessageParser<SetAllowOtherApplyFriendCsReq>(() => new SetAllowOtherApplyFriendCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NLIPKPLKCPOFieldNumber = 8;

	private bool nLIPKPLKCPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetAllowOtherApplyFriendCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetAllowOtherApplyFriendCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NLIPKPLKCPO
	{
		get
		{
			return nLIPKPLKCPO_;
		}
		set
		{
			nLIPKPLKCPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAllowOtherApplyFriendCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAllowOtherApplyFriendCsReq(SetAllowOtherApplyFriendCsReq other)
		: this()
	{
		nLIPKPLKCPO_ = other.nLIPKPLKCPO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAllowOtherApplyFriendCsReq Clone()
	{
		return new SetAllowOtherApplyFriendCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetAllowOtherApplyFriendCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetAllowOtherApplyFriendCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLIPKPLKCPO != other.NLIPKPLKCPO)
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
		if (NLIPKPLKCPO)
		{
			num ^= NLIPKPLKCPO.GetHashCode();
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
		if (NLIPKPLKCPO)
		{
			output.WriteRawTag(64);
			output.WriteBool(NLIPKPLKCPO);
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
		if (NLIPKPLKCPO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetAllowOtherApplyFriendCsReq other)
	{
		if (other != null)
		{
			if (other.NLIPKPLKCPO)
			{
				NLIPKPLKCPO = other.NLIPKPLKCPO;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			if (num != 64)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NLIPKPLKCPO = input.ReadBool();
			}
		}
	}
}
