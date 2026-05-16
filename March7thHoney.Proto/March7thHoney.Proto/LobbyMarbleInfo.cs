using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyMarbleInfo : IMessage<LobbyMarbleInfo>, IMessage, IEquatable<LobbyMarbleInfo>, IDeepCloneable<LobbyMarbleInfo>, IBufferMessage
{
	private static readonly MessageParser<LobbyMarbleInfo> _parser = new MessageParser<LobbyMarbleInfo>(() => new LobbyMarbleInfo());

	private UnknownFieldSet _unknownFields;

	public const int PJCGAJPDOBNFieldNumber = 1;

	private uint pJCGAJPDOBN_;

	public const int RankFieldNumber = 2;

	private uint rank_;

	public const int AOPJPCPNACHFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_aOPJPCPNACH_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> aOPJPCPNACH_ = new RepeatedField<uint>();

	public const int ScoreIdFieldNumber = 4;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyMarbleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyMarbleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJCGAJPDOBN
	{
		get
		{
			return pJCGAJPDOBN_;
		}
		set
		{
			pJCGAJPDOBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AOPJPCPNACH => aOPJPCPNACH_;

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
	public LobbyMarbleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarbleInfo(LobbyMarbleInfo other)
		: this()
	{
		pJCGAJPDOBN_ = other.pJCGAJPDOBN_;
		rank_ = other.rank_;
		aOPJPCPNACH_ = other.aOPJPCPNACH_.Clone();
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarbleInfo Clone()
	{
		return new LobbyMarbleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyMarbleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyMarbleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJCGAJPDOBN != other.PJCGAJPDOBN)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (!aOPJPCPNACH_.Equals(other.aOPJPCPNACH_))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		if (PJCGAJPDOBN != 0)
		{
			num ^= PJCGAJPDOBN.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		num ^= aOPJPCPNACH_.GetHashCode();
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		if (PJCGAJPDOBN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PJCGAJPDOBN);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Rank);
		}
		aOPJPCPNACH_.WriteTo(ref output, _repeated_aOPJPCPNACH_codec);
		if (ScoreId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ScoreId);
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
		if (PJCGAJPDOBN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJCGAJPDOBN);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		num += aOPJPCPNACH_.CalculateSize(_repeated_aOPJPCPNACH_codec);
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyMarbleInfo other)
	{
		if (other != null)
		{
			if (other.PJCGAJPDOBN != 0)
			{
				PJCGAJPDOBN = other.PJCGAJPDOBN;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			aOPJPCPNACH_.Add(other.aOPJPCPNACH_);
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
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
				PJCGAJPDOBN = input.ReadUInt32();
				break;
			case 16u:
				Rank = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				aOPJPCPNACH_.AddEntriesFrom(ref input, _repeated_aOPJPCPNACH_codec);
				break;
			case 32u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
