using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PMBIHJLAIPL : IMessage<PMBIHJLAIPL>, IMessage, IEquatable<PMBIHJLAIPL>, IDeepCloneable<PMBIHJLAIPL>, IBufferMessage
{
	private static readonly MessageParser<PMBIHJLAIPL> _parser = new MessageParser<PMBIHJLAIPL>(() => new PMBIHJLAIPL());

	private UnknownFieldSet _unknownFields;

	public const int NJACMMNPCBJFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_nJACMMNPCBJ_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> nJACMMNPCBJ_ = new RepeatedField<uint>();

	public const int KBBPNKGGCPNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_kBBPNKGGCPN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> kBBPNKGGCPN_ = new RepeatedField<uint>();

	public const int LPJIJHGPGHMFieldNumber = 8;

	private uint lPJIJHGPGHM_;

	public const int OPHPMKFGLBAFieldNumber = 9;

	private uint oPHPMKFGLBA_;

	public const int BGDGGALAODOFieldNumber = 11;

	private JPFIELFEFHD bGDGGALAODO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PMBIHJLAIPL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PMBIHJLAIPLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NJACMMNPCBJ => nJACMMNPCBJ_;

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
	public JPFIELFEFHD BGDGGALAODO
	{
		get
		{
			return bGDGGALAODO_;
		}
		set
		{
			bGDGGALAODO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBIHJLAIPL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBIHJLAIPL(PMBIHJLAIPL other)
		: this()
	{
		nJACMMNPCBJ_ = other.nJACMMNPCBJ_.Clone();
		kBBPNKGGCPN_ = other.kBBPNKGGCPN_.Clone();
		lPJIJHGPGHM_ = other.lPJIJHGPGHM_;
		oPHPMKFGLBA_ = other.oPHPMKFGLBA_;
		bGDGGALAODO_ = ((other.bGDGGALAODO_ != null) ? other.bGDGGALAODO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBIHJLAIPL Clone()
	{
		return new PMBIHJLAIPL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PMBIHJLAIPL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PMBIHJLAIPL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nJACMMNPCBJ_.Equals(other.nJACMMNPCBJ_))
		{
			return false;
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
		if (!object.Equals(BGDGGALAODO, other.BGDGGALAODO))
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
		num ^= nJACMMNPCBJ_.GetHashCode();
		num ^= kBBPNKGGCPN_.GetHashCode();
		if (LPJIJHGPGHM != 0)
		{
			num ^= LPJIJHGPGHM.GetHashCode();
		}
		if (OPHPMKFGLBA != 0)
		{
			num ^= OPHPMKFGLBA.GetHashCode();
		}
		if (bGDGGALAODO_ != null)
		{
			num ^= BGDGGALAODO.GetHashCode();
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
		nJACMMNPCBJ_.WriteTo(ref output, _repeated_nJACMMNPCBJ_codec);
		kBBPNKGGCPN_.WriteTo(ref output, _repeated_kBBPNKGGCPN_codec);
		if (LPJIJHGPGHM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LPJIJHGPGHM);
		}
		if (OPHPMKFGLBA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OPHPMKFGLBA);
		}
		if (bGDGGALAODO_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BGDGGALAODO);
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
		num += nJACMMNPCBJ_.CalculateSize(_repeated_nJACMMNPCBJ_codec);
		num += kBBPNKGGCPN_.CalculateSize(_repeated_kBBPNKGGCPN_codec);
		if (LPJIJHGPGHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPJIJHGPGHM);
		}
		if (OPHPMKFGLBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPHPMKFGLBA);
		}
		if (bGDGGALAODO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGDGGALAODO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PMBIHJLAIPL other)
	{
		if (other == null)
		{
			return;
		}
		nJACMMNPCBJ_.Add(other.nJACMMNPCBJ_);
		kBBPNKGGCPN_.Add(other.kBBPNKGGCPN_);
		if (other.LPJIJHGPGHM != 0)
		{
			LPJIJHGPGHM = other.LPJIJHGPGHM;
		}
		if (other.OPHPMKFGLBA != 0)
		{
			OPHPMKFGLBA = other.OPHPMKFGLBA;
		}
		if (other.bGDGGALAODO_ != null)
		{
			if (bGDGGALAODO_ == null)
			{
				BGDGGALAODO = new JPFIELFEFHD();
			}
			BGDGGALAODO.MergeFrom(other.BGDGGALAODO);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 32u:
			case 34u:
				nJACMMNPCBJ_.AddEntriesFrom(ref input, _repeated_nJACMMNPCBJ_codec);
				break;
			case 56u:
			case 58u:
				kBBPNKGGCPN_.AddEntriesFrom(ref input, _repeated_kBBPNKGGCPN_codec);
				break;
			case 64u:
				LPJIJHGPGHM = input.ReadUInt32();
				break;
			case 72u:
				OPHPMKFGLBA = input.ReadUInt32();
				break;
			case 90u:
				if (bGDGGALAODO_ == null)
				{
					BGDGGALAODO = new JPFIELFEFHD();
				}
				input.ReadMessage(BGDGGALAODO);
				break;
			}
		}
	}
}
