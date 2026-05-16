using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkGetInfoScRsp : IMessage<ClockParkGetInfoScRsp>, IMessage, IEquatable<ClockParkGetInfoScRsp>, IDeepCloneable<ClockParkGetInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<ClockParkGetInfoScRsp> _parser = new MessageParser<ClockParkGetInfoScRsp>(() => new ClockParkGetInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 1;

	private uint progress_;

	public const int ADJEHBLLBNHFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_aDJEHBLLBNH_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> aDJEHBLLBNH_ = new RepeatedField<uint>();

	public const int NIECFDLJPFIFieldNumber = 6;

	private static readonly FieldCodec<DHBCCMMHNCK> _repeated_nIECFDLJPFI_codec = FieldCodec.ForMessage(50u, DHBCCMMHNCK.Parser);

	private readonly RepeatedField<DHBCCMMHNCK> nIECFDLJPFI_ = new RepeatedField<DHBCCMMHNCK>();

	public const int CDNGKOFBHLGFieldNumber = 8;

	private uint cDNGKOFBHLG_;

	public const int HLNEMLMKECPFieldNumber = 12;

	private uint hLNEMLMKECP_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkGetInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkGetInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ADJEHBLLBNH => aDJEHBLLBNH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DHBCCMMHNCK> NIECFDLJPFI => nIECFDLJPFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDNGKOFBHLG
	{
		get
		{
			return cDNGKOFBHLG_;
		}
		set
		{
			cDNGKOFBHLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HLNEMLMKECP
	{
		get
		{
			return hLNEMLMKECP_;
		}
		set
		{
			hLNEMLMKECP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetInfoScRsp(ClockParkGetInfoScRsp other)
		: this()
	{
		progress_ = other.progress_;
		aDJEHBLLBNH_ = other.aDJEHBLLBNH_.Clone();
		nIECFDLJPFI_ = other.nIECFDLJPFI_.Clone();
		cDNGKOFBHLG_ = other.cDNGKOFBHLG_;
		hLNEMLMKECP_ = other.hLNEMLMKECP_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetInfoScRsp Clone()
	{
		return new ClockParkGetInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkGetInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkGetInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (!aDJEHBLLBNH_.Equals(other.aDJEHBLLBNH_))
		{
			return false;
		}
		if (!nIECFDLJPFI_.Equals(other.nIECFDLJPFI_))
		{
			return false;
		}
		if (CDNGKOFBHLG != other.CDNGKOFBHLG)
		{
			return false;
		}
		if (HLNEMLMKECP != other.HLNEMLMKECP)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		num ^= aDJEHBLLBNH_.GetHashCode();
		num ^= nIECFDLJPFI_.GetHashCode();
		if (CDNGKOFBHLG != 0)
		{
			num ^= CDNGKOFBHLG.GetHashCode();
		}
		if (HLNEMLMKECP != 0)
		{
			num ^= HLNEMLMKECP.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (Progress != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Progress);
		}
		aDJEHBLLBNH_.WriteTo(ref output, _repeated_aDJEHBLLBNH_codec);
		nIECFDLJPFI_.WriteTo(ref output, _repeated_nIECFDLJPFI_codec);
		if (CDNGKOFBHLG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CDNGKOFBHLG);
		}
		if (HLNEMLMKECP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HLNEMLMKECP);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		num += aDJEHBLLBNH_.CalculateSize(_repeated_aDJEHBLLBNH_codec);
		num += nIECFDLJPFI_.CalculateSize(_repeated_nIECFDLJPFI_codec);
		if (CDNGKOFBHLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDNGKOFBHLG);
		}
		if (HLNEMLMKECP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HLNEMLMKECP);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkGetInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			aDJEHBLLBNH_.Add(other.aDJEHBLLBNH_);
			nIECFDLJPFI_.Add(other.nIECFDLJPFI_);
			if (other.CDNGKOFBHLG != 0)
			{
				CDNGKOFBHLG = other.CDNGKOFBHLG;
			}
			if (other.HLNEMLMKECP != 0)
			{
				HLNEMLMKECP = other.HLNEMLMKECP;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				Progress = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				aDJEHBLLBNH_.AddEntriesFrom(ref input, _repeated_aDJEHBLLBNH_codec);
				break;
			case 50u:
				nIECFDLJPFI_.AddEntriesFrom(ref input, _repeated_nIECFDLJPFI_codec);
				break;
			case 64u:
				CDNGKOFBHLG = input.ReadUInt32();
				break;
			case 96u:
				HLNEMLMKECP = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
