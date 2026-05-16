using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AAKHENHMIFM : IMessage<AAKHENHMIFM>, IMessage, IEquatable<AAKHENHMIFM>, IDeepCloneable<AAKHENHMIFM>, IBufferMessage
{
	private static readonly MessageParser<AAKHENHMIFM> _parser = new MessageParser<AAKHENHMIFM>(() => new AAKHENHMIFM());

	private UnknownFieldSet _unknownFields;

	public const int OFAMBDEICMEFieldNumber = 1;

	private bool oFAMBDEICME_;

	public const int PBAGJGMOLFBFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_pBAGJGMOLFB_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> pBAGJGMOLFB_ = new RepeatedField<uint>();

	public const int KNFCAGFAHBJFieldNumber = 3;

	private uint kNFCAGFAHBJ_;

	public const int BDECLDMDNGIFieldNumber = 4;

	private uint bDECLDMDNGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AAKHENHMIFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AAKHENHMIFMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OFAMBDEICME
	{
		get
		{
			return oFAMBDEICME_;
		}
		set
		{
			oFAMBDEICME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PBAGJGMOLFB => pBAGJGMOLFB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KNFCAGFAHBJ
	{
		get
		{
			return kNFCAGFAHBJ_;
		}
		set
		{
			kNFCAGFAHBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDECLDMDNGI
	{
		get
		{
			return bDECLDMDNGI_;
		}
		set
		{
			bDECLDMDNGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAKHENHMIFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAKHENHMIFM(AAKHENHMIFM other)
		: this()
	{
		oFAMBDEICME_ = other.oFAMBDEICME_;
		pBAGJGMOLFB_ = other.pBAGJGMOLFB_.Clone();
		kNFCAGFAHBJ_ = other.kNFCAGFAHBJ_;
		bDECLDMDNGI_ = other.bDECLDMDNGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAKHENHMIFM Clone()
	{
		return new AAKHENHMIFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AAKHENHMIFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AAKHENHMIFM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFAMBDEICME != other.OFAMBDEICME)
		{
			return false;
		}
		if (!pBAGJGMOLFB_.Equals(other.pBAGJGMOLFB_))
		{
			return false;
		}
		if (KNFCAGFAHBJ != other.KNFCAGFAHBJ)
		{
			return false;
		}
		if (BDECLDMDNGI != other.BDECLDMDNGI)
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
		if (OFAMBDEICME)
		{
			num ^= OFAMBDEICME.GetHashCode();
		}
		num ^= pBAGJGMOLFB_.GetHashCode();
		if (KNFCAGFAHBJ != 0)
		{
			num ^= KNFCAGFAHBJ.GetHashCode();
		}
		if (BDECLDMDNGI != 0)
		{
			num ^= BDECLDMDNGI.GetHashCode();
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
		if (OFAMBDEICME)
		{
			output.WriteRawTag(8);
			output.WriteBool(OFAMBDEICME);
		}
		pBAGJGMOLFB_.WriteTo(ref output, _repeated_pBAGJGMOLFB_codec);
		if (KNFCAGFAHBJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KNFCAGFAHBJ);
		}
		if (BDECLDMDNGI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BDECLDMDNGI);
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
		if (OFAMBDEICME)
		{
			num += 2;
		}
		num += pBAGJGMOLFB_.CalculateSize(_repeated_pBAGJGMOLFB_codec);
		if (KNFCAGFAHBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KNFCAGFAHBJ);
		}
		if (BDECLDMDNGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDECLDMDNGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AAKHENHMIFM other)
	{
		if (other != null)
		{
			if (other.OFAMBDEICME)
			{
				OFAMBDEICME = other.OFAMBDEICME;
			}
			pBAGJGMOLFB_.Add(other.pBAGJGMOLFB_);
			if (other.KNFCAGFAHBJ != 0)
			{
				KNFCAGFAHBJ = other.KNFCAGFAHBJ;
			}
			if (other.BDECLDMDNGI != 0)
			{
				BDECLDMDNGI = other.BDECLDMDNGI;
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
				OFAMBDEICME = input.ReadBool();
				break;
			case 16u:
			case 18u:
				pBAGJGMOLFB_.AddEntriesFrom(ref input, _repeated_pBAGJGMOLFB_codec);
				break;
			case 24u:
				KNFCAGFAHBJ = input.ReadUInt32();
				break;
			case 32u:
				BDECLDMDNGI = input.ReadUInt32();
				break;
			}
		}
	}
}
