using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueLayerSettlement : IMessage<ChessRogueLayerSettlement>, IMessage, IEquatable<ChessRogueLayerSettlement>, IDeepCloneable<ChessRogueLayerSettlement>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueLayerSettlement> _parser = new MessageParser<ChessRogueLayerSettlement>(() => new ChessRogueLayerSettlement());

	private UnknownFieldSet _unknownFields;

	public const int DifficultyLevelFieldNumber = 4;

	private uint difficultyLevel_;

	public const int NDMLEGLIOGNFieldNumber = 12;

	private FIILPHKLFEK nDMLEGLIOGN_;

	public const int INGCDIAFAFGFieldNumber = 15;

	private uint iNGCDIAFAFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueLayerSettlement> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueLayerSettlementReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIILPHKLFEK NDMLEGLIOGN
	{
		get
		{
			return nDMLEGLIOGN_;
		}
		set
		{
			nDMLEGLIOGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INGCDIAFAFG
	{
		get
		{
			return iNGCDIAFAFG_;
		}
		set
		{
			iNGCDIAFAFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLayerSettlement()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLayerSettlement(ChessRogueLayerSettlement other)
		: this()
	{
		difficultyLevel_ = other.difficultyLevel_;
		nDMLEGLIOGN_ = ((other.nDMLEGLIOGN_ != null) ? other.nDMLEGLIOGN_.Clone() : null);
		iNGCDIAFAFG_ = other.iNGCDIAFAFG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueLayerSettlement Clone()
	{
		return new ChessRogueLayerSettlement(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueLayerSettlement);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueLayerSettlement other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (!object.Equals(NDMLEGLIOGN, other.NDMLEGLIOGN))
		{
			return false;
		}
		if (INGCDIAFAFG != other.INGCDIAFAFG)
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
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (nDMLEGLIOGN_ != null)
		{
			num ^= NDMLEGLIOGN.GetHashCode();
		}
		if (INGCDIAFAFG != 0)
		{
			num ^= INGCDIAFAFG.GetHashCode();
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
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DifficultyLevel);
		}
		if (nDMLEGLIOGN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NDMLEGLIOGN);
		}
		if (INGCDIAFAFG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(INGCDIAFAFG);
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
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (nDMLEGLIOGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDMLEGLIOGN);
		}
		if (INGCDIAFAFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INGCDIAFAFG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueLayerSettlement other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DifficultyLevel != 0)
		{
			DifficultyLevel = other.DifficultyLevel;
		}
		if (other.nDMLEGLIOGN_ != null)
		{
			if (nDMLEGLIOGN_ == null)
			{
				NDMLEGLIOGN = new FIILPHKLFEK();
			}
			NDMLEGLIOGN.MergeFrom(other.NDMLEGLIOGN);
		}
		if (other.INGCDIAFAFG != 0)
		{
			INGCDIAFAFG = other.INGCDIAFAFG;
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
				DifficultyLevel = input.ReadUInt32();
				break;
			case 98u:
				if (nDMLEGLIOGN_ == null)
				{
					NDMLEGLIOGN = new FIILPHKLFEK();
				}
				input.ReadMessage(NDMLEGLIOGN);
				break;
			case 120u:
				INGCDIAFAFG = input.ReadUInt32();
				break;
			}
		}
	}
}
