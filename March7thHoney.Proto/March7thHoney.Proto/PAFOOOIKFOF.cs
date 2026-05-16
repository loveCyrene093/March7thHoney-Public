using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PAFOOOIKFOF : IMessage<PAFOOOIKFOF>, IMessage, IEquatable<PAFOOOIKFOF>, IDeepCloneable<PAFOOOIKFOF>, IBufferMessage
{
	private static readonly MessageParser<PAFOOOIKFOF> _parser = new MessageParser<PAFOOOIKFOF>(() => new PAFOOOIKFOF());

	private UnknownFieldSet _unknownFields;

	public const int HCPAHPCOEKKFieldNumber = 3;

	private uint hCPAHPCOEKK_;

	public const int NumFieldNumber = 7;

	private uint num_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PAFOOOIKFOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PAFOOOIKFOFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCPAHPCOEKK
	{
		get
		{
			return hCPAHPCOEKK_;
		}
		set
		{
			hCPAHPCOEKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAFOOOIKFOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAFOOOIKFOF(PAFOOOIKFOF other)
		: this()
	{
		hCPAHPCOEKK_ = other.hCPAHPCOEKK_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAFOOOIKFOF Clone()
	{
		return new PAFOOOIKFOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PAFOOOIKFOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PAFOOOIKFOF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCPAHPCOEKK != other.HCPAHPCOEKK)
		{
			return false;
		}
		if (Num != other.Num)
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
		if (HCPAHPCOEKK != 0)
		{
			num ^= HCPAHPCOEKK.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
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
		if (HCPAHPCOEKK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HCPAHPCOEKK);
		}
		if (Num != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Num);
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
		if (HCPAHPCOEKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCPAHPCOEKK);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PAFOOOIKFOF other)
	{
		if (other != null)
		{
			if (other.HCPAHPCOEKK != 0)
			{
				HCPAHPCOEKK = other.HCPAHPCOEKK;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
			case 24u:
				HCPAHPCOEKK = input.ReadUInt32();
				break;
			case 56u:
				Num = input.ReadUInt32();
				break;
			}
		}
	}
}
