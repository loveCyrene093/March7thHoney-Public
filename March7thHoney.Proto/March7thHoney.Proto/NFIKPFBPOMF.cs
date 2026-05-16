using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NFIKPFBPOMF : IMessage<NFIKPFBPOMF>, IMessage, IEquatable<NFIKPFBPOMF>, IDeepCloneable<NFIKPFBPOMF>, IBufferMessage
{
	private static readonly MessageParser<NFIKPFBPOMF> _parser = new MessageParser<NFIKPFBPOMF>(() => new NFIKPFBPOMF());

	private UnknownFieldSet _unknownFields;

	public const int ACCLBAGKGELFieldNumber = 1;

	private uint aCCLBAGKGEL_;

	public const int KEDAEABLGABFieldNumber = 2;

	private uint kEDAEABLGAB_;

	public const int ECIJEKJAMPKFieldNumber = 5;

	private uint eCIJEKJAMPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NFIKPFBPOMF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NFIKPFBPOMFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACCLBAGKGEL
	{
		get
		{
			return aCCLBAGKGEL_;
		}
		set
		{
			aCCLBAGKGEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEDAEABLGAB
	{
		get
		{
			return kEDAEABLGAB_;
		}
		set
		{
			kEDAEABLGAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECIJEKJAMPK
	{
		get
		{
			return eCIJEKJAMPK_;
		}
		set
		{
			eCIJEKJAMPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFIKPFBPOMF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFIKPFBPOMF(NFIKPFBPOMF other)
		: this()
	{
		aCCLBAGKGEL_ = other.aCCLBAGKGEL_;
		kEDAEABLGAB_ = other.kEDAEABLGAB_;
		eCIJEKJAMPK_ = other.eCIJEKJAMPK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFIKPFBPOMF Clone()
	{
		return new NFIKPFBPOMF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NFIKPFBPOMF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NFIKPFBPOMF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ACCLBAGKGEL != other.ACCLBAGKGEL)
		{
			return false;
		}
		if (KEDAEABLGAB != other.KEDAEABLGAB)
		{
			return false;
		}
		if (ECIJEKJAMPK != other.ECIJEKJAMPK)
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
		if (ACCLBAGKGEL != 0)
		{
			num ^= ACCLBAGKGEL.GetHashCode();
		}
		if (KEDAEABLGAB != 0)
		{
			num ^= KEDAEABLGAB.GetHashCode();
		}
		if (ECIJEKJAMPK != 0)
		{
			num ^= ECIJEKJAMPK.GetHashCode();
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
		if (ACCLBAGKGEL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ACCLBAGKGEL);
		}
		if (KEDAEABLGAB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KEDAEABLGAB);
		}
		if (ECIJEKJAMPK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ECIJEKJAMPK);
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
		if (ACCLBAGKGEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACCLBAGKGEL);
		}
		if (KEDAEABLGAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEDAEABLGAB);
		}
		if (ECIJEKJAMPK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECIJEKJAMPK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NFIKPFBPOMF other)
	{
		if (other != null)
		{
			if (other.ACCLBAGKGEL != 0)
			{
				ACCLBAGKGEL = other.ACCLBAGKGEL;
			}
			if (other.KEDAEABLGAB != 0)
			{
				KEDAEABLGAB = other.KEDAEABLGAB;
			}
			if (other.ECIJEKJAMPK != 0)
			{
				ECIJEKJAMPK = other.ECIJEKJAMPK;
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
				ACCLBAGKGEL = input.ReadUInt32();
				break;
			case 16u:
				KEDAEABLGAB = input.ReadUInt32();
				break;
			case 40u:
				ECIJEKJAMPK = input.ReadUInt32();
				break;
			}
		}
	}
}
