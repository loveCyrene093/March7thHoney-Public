using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnTakeExtraHcoinScNotify : IMessage<PlayerReturnTakeExtraHcoinScNotify>, IMessage, IEquatable<PlayerReturnTakeExtraHcoinScNotify>, IDeepCloneable<PlayerReturnTakeExtraHcoinScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnTakeExtraHcoinScNotify> _parser = new MessageParser<PlayerReturnTakeExtraHcoinScNotify>(() => new PlayerReturnTakeExtraHcoinScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HBPNBAPCHNJFieldNumber = 1;

	private uint hBPNBAPCHNJ_;

	public const int ADDCPAGHJNDFieldNumber = 10;

	private uint aDDCPAGHJND_;

	public const int BDFMCPBINKEFieldNumber = 12;

	private bool bDFMCPBINKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnTakeExtraHcoinScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnTakeExtraHcoinScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBPNBAPCHNJ
	{
		get
		{
			return hBPNBAPCHNJ_;
		}
		set
		{
			hBPNBAPCHNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ADDCPAGHJND
	{
		get
		{
			return aDDCPAGHJND_;
		}
		set
		{
			aDDCPAGHJND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BDFMCPBINKE
	{
		get
		{
			return bDFMCPBINKE_;
		}
		set
		{
			bDFMCPBINKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeExtraHcoinScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeExtraHcoinScNotify(PlayerReturnTakeExtraHcoinScNotify other)
		: this()
	{
		hBPNBAPCHNJ_ = other.hBPNBAPCHNJ_;
		aDDCPAGHJND_ = other.aDDCPAGHJND_;
		bDFMCPBINKE_ = other.bDFMCPBINKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakeExtraHcoinScNotify Clone()
	{
		return new PlayerReturnTakeExtraHcoinScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnTakeExtraHcoinScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnTakeExtraHcoinScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBPNBAPCHNJ != other.HBPNBAPCHNJ)
		{
			return false;
		}
		if (ADDCPAGHJND != other.ADDCPAGHJND)
		{
			return false;
		}
		if (BDFMCPBINKE != other.BDFMCPBINKE)
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
		if (HBPNBAPCHNJ != 0)
		{
			num ^= HBPNBAPCHNJ.GetHashCode();
		}
		if (ADDCPAGHJND != 0)
		{
			num ^= ADDCPAGHJND.GetHashCode();
		}
		if (BDFMCPBINKE)
		{
			num ^= BDFMCPBINKE.GetHashCode();
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
		if (HBPNBAPCHNJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HBPNBAPCHNJ);
		}
		if (ADDCPAGHJND != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ADDCPAGHJND);
		}
		if (BDFMCPBINKE)
		{
			output.WriteRawTag(96);
			output.WriteBool(BDFMCPBINKE);
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
		if (HBPNBAPCHNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBPNBAPCHNJ);
		}
		if (ADDCPAGHJND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ADDCPAGHJND);
		}
		if (BDFMCPBINKE)
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
	public void MergeFrom(PlayerReturnTakeExtraHcoinScNotify other)
	{
		if (other != null)
		{
			if (other.HBPNBAPCHNJ != 0)
			{
				HBPNBAPCHNJ = other.HBPNBAPCHNJ;
			}
			if (other.ADDCPAGHJND != 0)
			{
				ADDCPAGHJND = other.ADDCPAGHJND;
			}
			if (other.BDFMCPBINKE)
			{
				BDFMCPBINKE = other.BDFMCPBINKE;
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
			case 8u:
				HBPNBAPCHNJ = input.ReadUInt32();
				break;
			case 80u:
				ADDCPAGHJND = input.ReadUInt32();
				break;
			case 96u:
				BDFMCPBINKE = input.ReadBool();
				break;
			}
		}
	}
}
