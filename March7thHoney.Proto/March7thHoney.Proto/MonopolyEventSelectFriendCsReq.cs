using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyEventSelectFriendCsReq : IMessage<MonopolyEventSelectFriendCsReq>, IMessage, IEquatable<MonopolyEventSelectFriendCsReq>, IDeepCloneable<MonopolyEventSelectFriendCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyEventSelectFriendCsReq> _parser = new MessageParser<MonopolyEventSelectFriendCsReq>(() => new MonopolyEventSelectFriendCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LIPHDPLGMNPFieldNumber = 4;

	private uint lIPHDPLGMNP_;

	public const int LDJKEEPNJDCFieldNumber = 10;

	private bool lDJKEEPNJDC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyEventSelectFriendCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyEventSelectFriendCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LIPHDPLGMNP
	{
		get
		{
			return lIPHDPLGMNP_;
		}
		set
		{
			lIPHDPLGMNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LDJKEEPNJDC
	{
		get
		{
			return lDJKEEPNJDC_;
		}
		set
		{
			lDJKEEPNJDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendCsReq(MonopolyEventSelectFriendCsReq other)
		: this()
	{
		lIPHDPLGMNP_ = other.lIPHDPLGMNP_;
		lDJKEEPNJDC_ = other.lDJKEEPNJDC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventSelectFriendCsReq Clone()
	{
		return new MonopolyEventSelectFriendCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyEventSelectFriendCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyEventSelectFriendCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LIPHDPLGMNP != other.LIPHDPLGMNP)
		{
			return false;
		}
		if (LDJKEEPNJDC != other.LDJKEEPNJDC)
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
		if (LIPHDPLGMNP != 0)
		{
			num ^= LIPHDPLGMNP.GetHashCode();
		}
		if (LDJKEEPNJDC)
		{
			num ^= LDJKEEPNJDC.GetHashCode();
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
		if (LIPHDPLGMNP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LIPHDPLGMNP);
		}
		if (LDJKEEPNJDC)
		{
			output.WriteRawTag(80);
			output.WriteBool(LDJKEEPNJDC);
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
		if (LIPHDPLGMNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LIPHDPLGMNP);
		}
		if (LDJKEEPNJDC)
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
	public void MergeFrom(MonopolyEventSelectFriendCsReq other)
	{
		if (other != null)
		{
			if (other.LIPHDPLGMNP != 0)
			{
				LIPHDPLGMNP = other.LIPHDPLGMNP;
			}
			if (other.LDJKEEPNJDC)
			{
				LDJKEEPNJDC = other.LDJKEEPNJDC;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 32u:
				LIPHDPLGMNP = input.ReadUInt32();
				break;
			case 80u:
				LDJKEEPNJDC = input.ReadBool();
				break;
			}
		}
	}
}
