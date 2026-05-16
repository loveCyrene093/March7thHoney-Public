using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherAvatarInfo : IMessage<AetherAvatarInfo>, IMessage, IEquatable<AetherAvatarInfo>, IDeepCloneable<AetherAvatarInfo>, IBufferMessage
{
	private static readonly MessageParser<AetherAvatarInfo> _parser = new MessageParser<AetherAvatarInfo>(() => new AetherAvatarInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int IndexFieldNumber = 2;

	private uint index_;

	public const int PromotionFieldNumber = 3;

	private uint promotion_;

	public const int OKMFEGDIONGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_oKMFEGDIONG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> oKMFEGDIONG_ = new RepeatedField<uint>();

	public const int KBNCLFCGHCKFieldNumber = 5;

	private HLJMCIBOBJO kBNCLFCGHCK_;

	public const int SpBarFieldNumber = 6;

	private SpBarInfo spBar_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherAvatarInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherAvatarInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OKMFEGDIONG => oKMFEGDIONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLJMCIBOBJO KBNCLFCGHCK
	{
		get
		{
			return kBNCLFCGHCK_;
		}
		set
		{
			kBNCLFCGHCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo SpBar
	{
		get
		{
			return spBar_;
		}
		set
		{
			spBar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherAvatarInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherAvatarInfo(AetherAvatarInfo other)
		: this()
	{
		id_ = other.id_;
		index_ = other.index_;
		promotion_ = other.promotion_;
		oKMFEGDIONG_ = other.oKMFEGDIONG_.Clone();
		kBNCLFCGHCK_ = other.kBNCLFCGHCK_;
		spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherAvatarInfo Clone()
	{
		return new AetherAvatarInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherAvatarInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherAvatarInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (!oKMFEGDIONG_.Equals(other.oKMFEGDIONG_))
		{
			return false;
		}
		if (KBNCLFCGHCK != other.KBNCLFCGHCK)
		{
			return false;
		}
		if (!object.Equals(SpBar, other.SpBar))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		num ^= oKMFEGDIONG_.GetHashCode();
		if (KBNCLFCGHCK != HLJMCIBOBJO.Mplpalikjhg)
		{
			num ^= KBNCLFCGHCK.GetHashCode();
		}
		if (spBar_ != null)
		{
			num ^= SpBar.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (Index != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Index);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Promotion);
		}
		oKMFEGDIONG_.WriteTo(ref output, _repeated_oKMFEGDIONG_codec);
		if (KBNCLFCGHCK != HLJMCIBOBJO.Mplpalikjhg)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)KBNCLFCGHCK);
		}
		if (spBar_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(SpBar);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		num += oKMFEGDIONG_.CalculateSize(_repeated_oKMFEGDIONG_codec);
		if (KBNCLFCGHCK != HLJMCIBOBJO.Mplpalikjhg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KBNCLFCGHCK);
		}
		if (spBar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpBar);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherAvatarInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Index != 0)
		{
			Index = other.Index;
		}
		if (other.Promotion != 0)
		{
			Promotion = other.Promotion;
		}
		oKMFEGDIONG_.Add(other.oKMFEGDIONG_);
		if (other.KBNCLFCGHCK != HLJMCIBOBJO.Mplpalikjhg)
		{
			KBNCLFCGHCK = other.KBNCLFCGHCK;
		}
		if (other.spBar_ != null)
		{
			if (spBar_ == null)
			{
				SpBar = new SpBarInfo();
			}
			SpBar.MergeFrom(other.SpBar);
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
			case 8u:
				Id = input.ReadUInt32();
				break;
			case 16u:
				Index = input.ReadUInt32();
				break;
			case 24u:
				Promotion = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				oKMFEGDIONG_.AddEntriesFrom(ref input, _repeated_oKMFEGDIONG_codec);
				break;
			case 40u:
				KBNCLFCGHCK = (HLJMCIBOBJO)input.ReadEnum();
				break;
			case 50u:
				if (spBar_ == null)
				{
					SpBar = new SpBarInfo();
				}
				input.ReadMessage(SpBar);
				break;
			}
		}
	}
}
