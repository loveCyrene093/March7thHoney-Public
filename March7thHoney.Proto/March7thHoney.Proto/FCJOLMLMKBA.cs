using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCJOLMLMKBA : IMessage<FCJOLMLMKBA>, IMessage, IEquatable<FCJOLMLMKBA>, IDeepCloneable<FCJOLMLMKBA>, IBufferMessage
{
	private static readonly MessageParser<FCJOLMLMKBA> _parser = new MessageParser<FCJOLMLMKBA>(() => new FCJOLMLMKBA());

	private UnknownFieldSet _unknownFields;

	public const int HNDHFPABBKDFieldNumber = 9;

	private uint hNDHFPABBKD_;

	public const int CntFieldNumber = 15;

	private uint cnt_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCJOLMLMKBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCJOLMLMKBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HNDHFPABBKD
	{
		get
		{
			return hNDHFPABBKD_;
		}
		set
		{
			hNDHFPABBKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Cnt
	{
		get
		{
			return cnt_;
		}
		set
		{
			cnt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCJOLMLMKBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCJOLMLMKBA(FCJOLMLMKBA other)
		: this()
	{
		hNDHFPABBKD_ = other.hNDHFPABBKD_;
		cnt_ = other.cnt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCJOLMLMKBA Clone()
	{
		return new FCJOLMLMKBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCJOLMLMKBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCJOLMLMKBA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HNDHFPABBKD != other.HNDHFPABBKD)
		{
			return false;
		}
		if (Cnt != other.Cnt)
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
		if (HNDHFPABBKD != 0)
		{
			num ^= HNDHFPABBKD.GetHashCode();
		}
		if (Cnt != 0)
		{
			num ^= Cnt.GetHashCode();
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
		if (HNDHFPABBKD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HNDHFPABBKD);
		}
		if (Cnt != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Cnt);
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
		if (HNDHFPABBKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNDHFPABBKD);
		}
		if (Cnt != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Cnt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FCJOLMLMKBA other)
	{
		if (other != null)
		{
			if (other.HNDHFPABBKD != 0)
			{
				HNDHFPABBKD = other.HNDHFPABBKD;
			}
			if (other.Cnt != 0)
			{
				Cnt = other.Cnt;
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
			case 72u:
				HNDHFPABBKD = input.ReadUInt32();
				break;
			case 120u:
				Cnt = input.ReadUInt32();
				break;
			}
		}
	}
}
