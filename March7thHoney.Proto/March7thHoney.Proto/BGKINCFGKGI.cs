using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGKINCFGKGI : IMessage<BGKINCFGKGI>, IMessage, IEquatable<BGKINCFGKGI>, IDeepCloneable<BGKINCFGKGI>, IBufferMessage
{
	private static readonly MessageParser<BGKINCFGKGI> _parser = new MessageParser<BGKINCFGKGI>(() => new BGKINCFGKGI());

	private UnknownFieldSet _unknownFields;

	public const int OEBHCDPDNHFFieldNumber = 1;

	private long oEBHCDPDNHF_;

	public const int MBMICCJEBJBFieldNumber = 3;

	private uint mBMICCJEBJB_;

	public const int NMCKJLHFPBJFieldNumber = 5;

	private long nMCKJLHFPBJ_;

	public const int HAOBJABCBMPFieldNumber = 7;

	private uint hAOBJABCBMP_;

	public const int GAMCPLJOEDKFieldNumber = 9;

	private bool gAMCPLJOEDK_;

	public const int DFLKNLMJOFBFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dFLKNLMJOFB_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dFLKNLMJOFB_ = new RepeatedField<uint>();

	public const int ADGBKKIMJOAFieldNumber = 13;

	private bool aDGBKKIMJOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGKINCFGKGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGKINCFGKGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OEBHCDPDNHF
	{
		get
		{
			return oEBHCDPDNHF_;
		}
		set
		{
			oEBHCDPDNHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBMICCJEBJB
	{
		get
		{
			return mBMICCJEBJB_;
		}
		set
		{
			mBMICCJEBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NMCKJLHFPBJ
	{
		get
		{
			return nMCKJLHFPBJ_;
		}
		set
		{
			nMCKJLHFPBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAOBJABCBMP
	{
		get
		{
			return hAOBJABCBMP_;
		}
		set
		{
			hAOBJABCBMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GAMCPLJOEDK
	{
		get
		{
			return gAMCPLJOEDK_;
		}
		set
		{
			gAMCPLJOEDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DFLKNLMJOFB => dFLKNLMJOFB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ADGBKKIMJOA
	{
		get
		{
			return aDGBKKIMJOA_;
		}
		set
		{
			aDGBKKIMJOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI(BGKINCFGKGI other)
		: this()
	{
		oEBHCDPDNHF_ = other.oEBHCDPDNHF_;
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		nMCKJLHFPBJ_ = other.nMCKJLHFPBJ_;
		hAOBJABCBMP_ = other.hAOBJABCBMP_;
		gAMCPLJOEDK_ = other.gAMCPLJOEDK_;
		dFLKNLMJOFB_ = other.dFLKNLMJOFB_.Clone();
		aDGBKKIMJOA_ = other.aDGBKKIMJOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI Clone()
	{
		return new BGKINCFGKGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGKINCFGKGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGKINCFGKGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OEBHCDPDNHF != other.OEBHCDPDNHF)
		{
			return false;
		}
		if (MBMICCJEBJB != other.MBMICCJEBJB)
		{
			return false;
		}
		if (NMCKJLHFPBJ != other.NMCKJLHFPBJ)
		{
			return false;
		}
		if (HAOBJABCBMP != other.HAOBJABCBMP)
		{
			return false;
		}
		if (GAMCPLJOEDK != other.GAMCPLJOEDK)
		{
			return false;
		}
		if (!dFLKNLMJOFB_.Equals(other.dFLKNLMJOFB_))
		{
			return false;
		}
		if (ADGBKKIMJOA != other.ADGBKKIMJOA)
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
		if (OEBHCDPDNHF != 0L)
		{
			num ^= OEBHCDPDNHF.GetHashCode();
		}
		if (MBMICCJEBJB != 0)
		{
			num ^= MBMICCJEBJB.GetHashCode();
		}
		if (NMCKJLHFPBJ != 0L)
		{
			num ^= NMCKJLHFPBJ.GetHashCode();
		}
		if (HAOBJABCBMP != 0)
		{
			num ^= HAOBJABCBMP.GetHashCode();
		}
		if (GAMCPLJOEDK)
		{
			num ^= GAMCPLJOEDK.GetHashCode();
		}
		num ^= dFLKNLMJOFB_.GetHashCode();
		if (ADGBKKIMJOA)
		{
			num ^= ADGBKKIMJOA.GetHashCode();
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
		if (OEBHCDPDNHF != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OEBHCDPDNHF);
		}
		if (MBMICCJEBJB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MBMICCJEBJB);
		}
		if (NMCKJLHFPBJ != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(NMCKJLHFPBJ);
		}
		if (HAOBJABCBMP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HAOBJABCBMP);
		}
		if (GAMCPLJOEDK)
		{
			output.WriteRawTag(72);
			output.WriteBool(GAMCPLJOEDK);
		}
		dFLKNLMJOFB_.WriteTo(ref output, _repeated_dFLKNLMJOFB_codec);
		if (ADGBKKIMJOA)
		{
			output.WriteRawTag(104);
			output.WriteBool(ADGBKKIMJOA);
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
		if (OEBHCDPDNHF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OEBHCDPDNHF);
		}
		if (MBMICCJEBJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBMICCJEBJB);
		}
		if (NMCKJLHFPBJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NMCKJLHFPBJ);
		}
		if (HAOBJABCBMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAOBJABCBMP);
		}
		if (GAMCPLJOEDK)
		{
			num += 2;
		}
		num += dFLKNLMJOFB_.CalculateSize(_repeated_dFLKNLMJOFB_codec);
		if (ADGBKKIMJOA)
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
	public void MergeFrom(BGKINCFGKGI other)
	{
		if (other != null)
		{
			if (other.OEBHCDPDNHF != 0L)
			{
				OEBHCDPDNHF = other.OEBHCDPDNHF;
			}
			if (other.MBMICCJEBJB != 0)
			{
				MBMICCJEBJB = other.MBMICCJEBJB;
			}
			if (other.NMCKJLHFPBJ != 0L)
			{
				NMCKJLHFPBJ = other.NMCKJLHFPBJ;
			}
			if (other.HAOBJABCBMP != 0)
			{
				HAOBJABCBMP = other.HAOBJABCBMP;
			}
			if (other.GAMCPLJOEDK)
			{
				GAMCPLJOEDK = other.GAMCPLJOEDK;
			}
			dFLKNLMJOFB_.Add(other.dFLKNLMJOFB_);
			if (other.ADGBKKIMJOA)
			{
				ADGBKKIMJOA = other.ADGBKKIMJOA;
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
				OEBHCDPDNHF = input.ReadInt64();
				break;
			case 24u:
				MBMICCJEBJB = input.ReadUInt32();
				break;
			case 40u:
				NMCKJLHFPBJ = input.ReadInt64();
				break;
			case 56u:
				HAOBJABCBMP = input.ReadUInt32();
				break;
			case 72u:
				GAMCPLJOEDK = input.ReadBool();
				break;
			case 96u:
			case 98u:
				dFLKNLMJOFB_.AddEntriesFrom(ref input, _repeated_dFLKNLMJOFB_codec);
				break;
			case 104u:
				ADGBKKIMJOA = input.ReadBool();
				break;
			}
		}
	}
}
