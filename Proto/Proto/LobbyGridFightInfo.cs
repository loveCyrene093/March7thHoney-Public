using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyGridFightInfo : IMessage<LobbyGridFightInfo>, IMessage, IEquatable<LobbyGridFightInfo>, IDeepCloneable<LobbyGridFightInfo>, IBufferMessage
{
	private static readonly MessageParser<LobbyGridFightInfo> _parser = new MessageParser<LobbyGridFightInfo>(() => new LobbyGridFightInfo());

	private UnknownFieldSet _unknownFields;

	public const int IHGBBHEBLKLFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_iHGBBHEBLKL_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> iHGBBHEBLKL_ = new RepeatedField<uint>();

	public const int GoldFieldNumber = 2;

	private uint gold_;

	public const int ScoreIdFieldNumber = 3;

	private uint scoreId_;

	public const int FCFGBADCGCCFieldNumber = 4;

	private string fCFGBADCGCC_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyGridFightInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyGridFightInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IHGBBHEBLKL => iHGBBHEBLKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FCFGBADCGCC
	{
		get
		{
			return fCFGBADCGCC_;
		}
		set
		{
			fCFGBADCGCC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGridFightInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGridFightInfo(LobbyGridFightInfo other)
		: this()
	{
		iHGBBHEBLKL_ = other.iHGBBHEBLKL_.Clone();
		gold_ = other.gold_;
		scoreId_ = other.scoreId_;
		fCFGBADCGCC_ = other.fCFGBADCGCC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGridFightInfo Clone()
	{
		return new LobbyGridFightInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyGridFightInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyGridFightInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iHGBBHEBLKL_.Equals(other.iHGBBHEBLKL_))
		{
			return false;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (FCFGBADCGCC != other.FCFGBADCGCC)
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
		num ^= iHGBBHEBLKL_.GetHashCode();
		if (Gold != 0)
		{
			num ^= Gold.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (FCFGBADCGCC.Length != 0)
		{
			num ^= FCFGBADCGCC.GetHashCode();
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
		iHGBBHEBLKL_.WriteTo(ref output, _repeated_iHGBBHEBLKL_codec);
		if (Gold != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Gold);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ScoreId);
		}
		if (FCFGBADCGCC.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(FCFGBADCGCC);
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
		num += iHGBBHEBLKL_.CalculateSize(_repeated_iHGBBHEBLKL_codec);
		if (Gold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (FCFGBADCGCC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FCFGBADCGCC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyGridFightInfo other)
	{
		if (other != null)
		{
			iHGBBHEBLKL_.Add(other.iHGBBHEBLKL_);
			if (other.Gold != 0)
			{
				Gold = other.Gold;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.FCFGBADCGCC.Length != 0)
			{
				FCFGBADCGCC = other.FCFGBADCGCC;
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
			case 10u:
				iHGBBHEBLKL_.AddEntriesFrom(ref input, _repeated_iHGBBHEBLKL_codec);
				break;
			case 16u:
				Gold = input.ReadUInt32();
				break;
			case 24u:
				ScoreId = input.ReadUInt32();
				break;
			case 34u:
				FCFGBADCGCC = input.ReadString();
				break;
			}
		}
	}
}
