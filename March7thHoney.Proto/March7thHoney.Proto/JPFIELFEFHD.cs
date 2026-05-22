using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JPFIELFEFHD : IMessage<JPFIELFEFHD>, IMessage, IEquatable<JPFIELFEFHD>, IDeepCloneable<JPFIELFEFHD>, IBufferMessage
{
	private static readonly MessageParser<JPFIELFEFHD> _parser = new MessageParser<JPFIELFEFHD>(() => new JPFIELFEFHD());

	private UnknownFieldSet _unknownFields;

	public const int KBBPNKGGCPNFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_kBBPNKGGCPN_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> kBBPNKGGCPN_ = new RepeatedField<uint>();

	public const int LPJIJHGPGHMFieldNumber = 6;

	private uint lPJIJHGPGHM_;

	public const int OPHPMKFGLBAFieldNumber = 13;

	private uint oPHPMKFGLBA_;

	public const int NJACMMNPCBJFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_nJACMMNPCBJ_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> nJACMMNPCBJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JPFIELFEFHD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JPFIELFEFHDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KBBPNKGGCPN => kBBPNKGGCPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPJIJHGPGHM
	{
		get
		{
			return lPJIJHGPGHM_;
		}
		set
		{
			lPJIJHGPGHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPHPMKFGLBA
	{
		get
		{
			return oPHPMKFGLBA_;
		}
		set
		{
			oPHPMKFGLBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NJACMMNPCBJ => nJACMMNPCBJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPFIELFEFHD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPFIELFEFHD(JPFIELFEFHD other)
		: this()
	{
		kBBPNKGGCPN_ = other.kBBPNKGGCPN_.Clone();
		lPJIJHGPGHM_ = other.lPJIJHGPGHM_;
		oPHPMKFGLBA_ = other.oPHPMKFGLBA_;
		nJACMMNPCBJ_ = other.nJACMMNPCBJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPFIELFEFHD Clone()
	{
		return new JPFIELFEFHD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JPFIELFEFHD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JPFIELFEFHD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kBBPNKGGCPN_.Equals(other.kBBPNKGGCPN_))
		{
			return false;
		}
		if (LPJIJHGPGHM != other.LPJIJHGPGHM)
		{
			return false;
		}
		if (OPHPMKFGLBA != other.OPHPMKFGLBA)
		{
			return false;
		}
		if (!nJACMMNPCBJ_.Equals(other.nJACMMNPCBJ_))
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
		num ^= kBBPNKGGCPN_.GetHashCode();
		if (LPJIJHGPGHM != 0)
		{
			num ^= LPJIJHGPGHM.GetHashCode();
		}
		if (OPHPMKFGLBA != 0)
		{
			num ^= OPHPMKFGLBA.GetHashCode();
		}
		num ^= nJACMMNPCBJ_.GetHashCode();
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
		kBBPNKGGCPN_.WriteTo(ref output, _repeated_kBBPNKGGCPN_codec);
		if (LPJIJHGPGHM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LPJIJHGPGHM);
		}
		if (OPHPMKFGLBA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OPHPMKFGLBA);
		}
		nJACMMNPCBJ_.WriteTo(ref output, _repeated_nJACMMNPCBJ_codec);
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
		num += kBBPNKGGCPN_.CalculateSize(_repeated_kBBPNKGGCPN_codec);
		if (LPJIJHGPGHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPJIJHGPGHM);
		}
		if (OPHPMKFGLBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPHPMKFGLBA);
		}
		num += nJACMMNPCBJ_.CalculateSize(_repeated_nJACMMNPCBJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JPFIELFEFHD other)
	{
		if (other != null)
		{
			kBBPNKGGCPN_.Add(other.kBBPNKGGCPN_);
			if (other.LPJIJHGPGHM != 0)
			{
				LPJIJHGPGHM = other.LPJIJHGPGHM;
			}
			if (other.OPHPMKFGLBA != 0)
			{
				OPHPMKFGLBA = other.OPHPMKFGLBA;
			}
			nJACMMNPCBJ_.Add(other.nJACMMNPCBJ_);
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
			case 10u:
				kBBPNKGGCPN_.AddEntriesFrom(ref input, _repeated_kBBPNKGGCPN_codec);
				break;
			case 48u:
				LPJIJHGPGHM = input.ReadUInt32();
				break;
			case 104u:
				OPHPMKFGLBA = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				nJACMMNPCBJ_.AddEntriesFrom(ref input, _repeated_nJACMMNPCBJ_codec);
				break;
			}
		}
	}
}
