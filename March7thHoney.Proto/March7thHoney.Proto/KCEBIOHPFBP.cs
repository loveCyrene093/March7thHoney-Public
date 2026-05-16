using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KCEBIOHPFBP : IMessage<KCEBIOHPFBP>, IMessage, IEquatable<KCEBIOHPFBP>, IDeepCloneable<KCEBIOHPFBP>, IBufferMessage
{
	private static readonly MessageParser<KCEBIOHPFBP> _parser = new MessageParser<KCEBIOHPFBP>(() => new KCEBIOHPFBP());

	private UnknownFieldSet _unknownFields;

	public const int ANOAMOLPGGKFieldNumber = 9;

	private uint aNOAMOLPGGK_;

	public const int DNNHCNCKJCMFieldNumber = 10;

	private long dNNHCNCKJCM_;

	public const int FHIMLMLKFJKFieldNumber = 12;

	private uint fHIMLMLKFJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KCEBIOHPFBP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KCEBIOHPFBPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANOAMOLPGGK
	{
		get
		{
			return aNOAMOLPGGK_;
		}
		set
		{
			aNOAMOLPGGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DNNHCNCKJCM
	{
		get
		{
			return dNNHCNCKJCM_;
		}
		set
		{
			dNNHCNCKJCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHIMLMLKFJK
	{
		get
		{
			return fHIMLMLKFJK_;
		}
		set
		{
			fHIMLMLKFJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEBIOHPFBP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEBIOHPFBP(KCEBIOHPFBP other)
		: this()
	{
		aNOAMOLPGGK_ = other.aNOAMOLPGGK_;
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		fHIMLMLKFJK_ = other.fHIMLMLKFJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEBIOHPFBP Clone()
	{
		return new KCEBIOHPFBP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KCEBIOHPFBP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KCEBIOHPFBP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ANOAMOLPGGK != other.ANOAMOLPGGK)
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (FHIMLMLKFJK != other.FHIMLMLKFJK)
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
		if (ANOAMOLPGGK != 0)
		{
			num ^= ANOAMOLPGGK.GetHashCode();
		}
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		if (FHIMLMLKFJK != 0)
		{
			num ^= FHIMLMLKFJK.GetHashCode();
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
		if (ANOAMOLPGGK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ANOAMOLPGGK);
		}
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(DNNHCNCKJCM);
		}
		if (FHIMLMLKFJK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FHIMLMLKFJK);
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
		if (ANOAMOLPGGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANOAMOLPGGK);
		}
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (FHIMLMLKFJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHIMLMLKFJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KCEBIOHPFBP other)
	{
		if (other != null)
		{
			if (other.ANOAMOLPGGK != 0)
			{
				ANOAMOLPGGK = other.ANOAMOLPGGK;
			}
			if (other.DNNHCNCKJCM != 0L)
			{
				DNNHCNCKJCM = other.DNNHCNCKJCM;
			}
			if (other.FHIMLMLKFJK != 0)
			{
				FHIMLMLKFJK = other.FHIMLMLKFJK;
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
				ANOAMOLPGGK = input.ReadUInt32();
				break;
			case 80u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 96u:
				FHIMLMLKFJK = input.ReadUInt32();
				break;
			}
		}
	}
}
