using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPABAKNJAHM : IMessage<DPABAKNJAHM>, IMessage, IEquatable<DPABAKNJAHM>, IDeepCloneable<DPABAKNJAHM>, IBufferMessage
{
	private static readonly MessageParser<DPABAKNJAHM> _parser = new MessageParser<DPABAKNJAHM>(() => new DPABAKNJAHM());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private IEEPGJIKEEM type_;

	public const int CntFieldNumber = 5;

	private uint cnt_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPABAKNJAHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPABAKNJAHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEEPGJIKEEM Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public DPABAKNJAHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPABAKNJAHM(DPABAKNJAHM other)
		: this()
	{
		type_ = other.type_;
		cnt_ = other.cnt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPABAKNJAHM Clone()
	{
		return new DPABAKNJAHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPABAKNJAHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPABAKNJAHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
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
		if (Type != IEEPGJIKEEM.Dmkleehjppd)
		{
			num ^= Type.GetHashCode();
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
		if (Type != IEEPGJIKEEM.Dmkleehjppd)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Cnt != 0)
		{
			output.WriteRawTag(40);
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
		if (Type != IEEPGJIKEEM.Dmkleehjppd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
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
	public void MergeFrom(DPABAKNJAHM other)
	{
		if (other != null)
		{
			if (other.Type != IEEPGJIKEEM.Dmkleehjppd)
			{
				Type = other.Type;
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
			case 8u:
				Type = (IEEPGJIKEEM)input.ReadEnum();
				break;
			case 40u:
				Cnt = input.ReadUInt32();
				break;
			}
		}
	}
}
