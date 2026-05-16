using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureDungeonFinishScNotify : IMessage<TreasureDungeonFinishScNotify>, IMessage, IEquatable<TreasureDungeonFinishScNotify>, IDeepCloneable<TreasureDungeonFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<TreasureDungeonFinishScNotify> _parser = new MessageParser<TreasureDungeonFinishScNotify>(() => new TreasureDungeonFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int DPAJMLNHDDGFieldNumber = 2;

	private static readonly MapField<uint, uint>.Codec _map_dPAJMLNHDDG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<uint, uint> dPAJMLNHDDG_ = new MapField<uint, uint>();

	public const int DEOBOJCCPFBFieldNumber = 6;

	private uint dEOBOJCCPFB_;

	public const int GCGALKPCHCPFieldNumber = 7;

	private static readonly MapField<uint, uint>.Codec _map_gCGALKPCHCP_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 58u);

	private readonly MapField<uint, uint> gCGALKPCHCP_ = new MapField<uint, uint>();

	public const int IsWinFieldNumber = 8;

	private bool isWin_;

	public const int DCKEEAKEOLCFieldNumber = 12;

	private uint dCKEEAKEOLC_;

	public const int BHMJFLGMICKFieldNumber = 14;

	private uint bHMJFLGMICK_;

	public const int TargetSideFieldNumber = 15;

	private uint targetSide_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureDungeonFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TreasureDungeonFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> DPAJMLNHDDG => dPAJMLNHDDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEOBOJCCPFB
	{
		get
		{
			return dEOBOJCCPFB_;
		}
		set
		{
			dEOBOJCCPFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> GCGALKPCHCP => gCGALKPCHCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCKEEAKEOLC
	{
		get
		{
			return dCKEEAKEOLC_;
		}
		set
		{
			dCKEEAKEOLC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHMJFLGMICK
	{
		get
		{
			return bHMJFLGMICK_;
		}
		set
		{
			bHMJFLGMICK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonFinishScNotify(TreasureDungeonFinishScNotify other)
		: this()
	{
		dPAJMLNHDDG_ = other.dPAJMLNHDDG_.Clone();
		dEOBOJCCPFB_ = other.dEOBOJCCPFB_;
		gCGALKPCHCP_ = other.gCGALKPCHCP_.Clone();
		isWin_ = other.isWin_;
		dCKEEAKEOLC_ = other.dCKEEAKEOLC_;
		bHMJFLGMICK_ = other.bHMJFLGMICK_;
		targetSide_ = other.targetSide_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonFinishScNotify Clone()
	{
		return new TreasureDungeonFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TreasureDungeonFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureDungeonFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!DPAJMLNHDDG.Equals(other.DPAJMLNHDDG))
		{
			return false;
		}
		if (DEOBOJCCPFB != other.DEOBOJCCPFB)
		{
			return false;
		}
		if (!GCGALKPCHCP.Equals(other.GCGALKPCHCP))
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (DCKEEAKEOLC != other.DCKEEAKEOLC)
		{
			return false;
		}
		if (BHMJFLGMICK != other.BHMJFLGMICK)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
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
		num ^= DPAJMLNHDDG.GetHashCode();
		if (DEOBOJCCPFB != 0)
		{
			num ^= DEOBOJCCPFB.GetHashCode();
		}
		num ^= GCGALKPCHCP.GetHashCode();
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (DCKEEAKEOLC != 0)
		{
			num ^= DCKEEAKEOLC.GetHashCode();
		}
		if (BHMJFLGMICK != 0)
		{
			num ^= BHMJFLGMICK.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
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
		dPAJMLNHDDG_.WriteTo(ref output, _map_dPAJMLNHDDG_codec);
		if (DEOBOJCCPFB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DEOBOJCCPFB);
		}
		gCGALKPCHCP_.WriteTo(ref output, _map_gCGALKPCHCP_codec);
		if (IsWin)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsWin);
		}
		if (DCKEEAKEOLC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DCKEEAKEOLC);
		}
		if (BHMJFLGMICK != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BHMJFLGMICK);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(TargetSide);
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
		num += dPAJMLNHDDG_.CalculateSize(_map_dPAJMLNHDDG_codec);
		if (DEOBOJCCPFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEOBOJCCPFB);
		}
		num += gCGALKPCHCP_.CalculateSize(_map_gCGALKPCHCP_codec);
		if (IsWin)
		{
			num += 2;
		}
		if (DCKEEAKEOLC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCKEEAKEOLC);
		}
		if (BHMJFLGMICK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHMJFLGMICK);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureDungeonFinishScNotify other)
	{
		if (other != null)
		{
			dPAJMLNHDDG_.MergeFrom(other.dPAJMLNHDDG_);
			if (other.DEOBOJCCPFB != 0)
			{
				DEOBOJCCPFB = other.DEOBOJCCPFB;
			}
			gCGALKPCHCP_.MergeFrom(other.gCGALKPCHCP_);
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.DCKEEAKEOLC != 0)
			{
				DCKEEAKEOLC = other.DCKEEAKEOLC;
			}
			if (other.BHMJFLGMICK != 0)
			{
				BHMJFLGMICK = other.BHMJFLGMICK;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
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
			case 18u:
				dPAJMLNHDDG_.AddEntriesFrom(ref input, _map_dPAJMLNHDDG_codec);
				break;
			case 48u:
				DEOBOJCCPFB = input.ReadUInt32();
				break;
			case 58u:
				gCGALKPCHCP_.AddEntriesFrom(ref input, _map_gCGALKPCHCP_codec);
				break;
			case 64u:
				IsWin = input.ReadBool();
				break;
			case 96u:
				DCKEEAKEOLC = input.ReadUInt32();
				break;
			case 112u:
				BHMJFLGMICK = input.ReadUInt32();
				break;
			case 120u:
				TargetSide = input.ReadUInt32();
				break;
			}
		}
	}
}
