using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PAGAEJKHFPO : IMessage<PAGAEJKHFPO>, IMessage, IEquatable<PAGAEJKHFPO>, IDeepCloneable<PAGAEJKHFPO>, IBufferMessage
{
	private static readonly MessageParser<PAGAEJKHFPO> _parser = new MessageParser<PAGAEJKHFPO>(() => new PAGAEJKHFPO());

	private UnknownFieldSet _unknownFields;

	public const int FCOKOGNOGCAFieldNumber = 9;

	private uint fCOKOGNOGCA_;

	public const int MOBBPMMKKMIFieldNumber = 10;

	private uint mOBBPMMKKMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PAGAEJKHFPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PAGAEJKHFPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCOKOGNOGCA
	{
		get
		{
			return fCOKOGNOGCA_;
		}
		set
		{
			fCOKOGNOGCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOBBPMMKKMI
	{
		get
		{
			return mOBBPMMKKMI_;
		}
		set
		{
			mOBBPMMKKMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAGAEJKHFPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAGAEJKHFPO(PAGAEJKHFPO other)
		: this()
	{
		fCOKOGNOGCA_ = other.fCOKOGNOGCA_;
		mOBBPMMKKMI_ = other.mOBBPMMKKMI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PAGAEJKHFPO Clone()
	{
		return new PAGAEJKHFPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PAGAEJKHFPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PAGAEJKHFPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FCOKOGNOGCA != other.FCOKOGNOGCA)
		{
			return false;
		}
		if (MOBBPMMKKMI != other.MOBBPMMKKMI)
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
		if (FCOKOGNOGCA != 0)
		{
			num ^= FCOKOGNOGCA.GetHashCode();
		}
		if (MOBBPMMKKMI != 0)
		{
			num ^= MOBBPMMKKMI.GetHashCode();
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
		if (FCOKOGNOGCA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FCOKOGNOGCA);
		}
		if (MOBBPMMKKMI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MOBBPMMKKMI);
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
		if (FCOKOGNOGCA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCOKOGNOGCA);
		}
		if (MOBBPMMKKMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOBBPMMKKMI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PAGAEJKHFPO other)
	{
		if (other != null)
		{
			if (other.FCOKOGNOGCA != 0)
			{
				FCOKOGNOGCA = other.FCOKOGNOGCA;
			}
			if (other.MOBBPMMKKMI != 0)
			{
				MOBBPMMKKMI = other.MOBBPMMKKMI;
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
				FCOKOGNOGCA = input.ReadUInt32();
				break;
			case 80u:
				MOBBPMMKKMI = input.ReadUInt32();
				break;
			}
		}
	}
}
