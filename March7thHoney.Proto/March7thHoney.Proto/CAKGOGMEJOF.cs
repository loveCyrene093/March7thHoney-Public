using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CAKGOGMEJOF : IMessage<CAKGOGMEJOF>, IMessage, IEquatable<CAKGOGMEJOF>, IDeepCloneable<CAKGOGMEJOF>, IBufferMessage
{
	private static readonly MessageParser<CAKGOGMEJOF> _parser = new MessageParser<CAKGOGMEJOF>(() => new CAKGOGMEJOF());

	private UnknownFieldSet _unknownFields;

	public const int MessageDatasFieldNumber = 1;

	private static readonly FieldCodec<PMNGJCDCGMM> _repeated_messageDatas_codec = FieldCodec.ForMessage(10u, PMNGJCDCGMM.Parser);

	private readonly RepeatedField<PMNGJCDCGMM> messageDatas_ = new RepeatedField<PMNGJCDCGMM>();

	public const int BLMPNONPLNIFieldNumber = 2;

	private static readonly MapField<uint, uint>.Codec _map_bLMPNONPLNI_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 18u);

	private readonly MapField<uint, uint> bLMPNONPLNI_ = new MapField<uint, uint>();

	public const int OMBLPOCHCHMFieldNumber = 3;

	private static readonly FieldCodec<CBELDECDCCI> _repeated_oMBLPOCHCHM_codec = FieldCodec.ForMessage(26u, CBELDECDCCI.Parser);

	private readonly RepeatedField<CBELDECDCCI> oMBLPOCHCHM_ = new RepeatedField<CBELDECDCCI>();

	public const int AreaIdFieldNumber = 4;

	private uint areaId_;

	public const int DifficultyLevelFieldNumber = 5;

	private uint difficultyLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CAKGOGMEJOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CAKGOGMEJOFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PMNGJCDCGMM> MessageDatas => messageDatas_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BLMPNONPLNI => bLMPNONPLNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CBELDECDCCI> OMBLPOCHCHM => oMBLPOCHCHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

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
	public CAKGOGMEJOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAKGOGMEJOF(CAKGOGMEJOF other)
		: this()
	{
		messageDatas_ = other.messageDatas_.Clone();
		bLMPNONPLNI_ = other.bLMPNONPLNI_.Clone();
		oMBLPOCHCHM_ = other.oMBLPOCHCHM_.Clone();
		areaId_ = other.areaId_;
		difficultyLevel_ = other.difficultyLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAKGOGMEJOF Clone()
	{
		return new CAKGOGMEJOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CAKGOGMEJOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CAKGOGMEJOF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!messageDatas_.Equals(other.messageDatas_))
		{
			return false;
		}
		if (!BLMPNONPLNI.Equals(other.BLMPNONPLNI))
		{
			return false;
		}
		if (!oMBLPOCHCHM_.Equals(other.oMBLPOCHCHM_))
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
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
		num ^= messageDatas_.GetHashCode();
		num ^= BLMPNONPLNI.GetHashCode();
		num ^= oMBLPOCHCHM_.GetHashCode();
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
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
		messageDatas_.WriteTo(ref output, _repeated_messageDatas_codec);
		bLMPNONPLNI_.WriteTo(ref output, _map_bLMPNONPLNI_codec);
		oMBLPOCHCHM_.WriteTo(ref output, _repeated_oMBLPOCHCHM_codec);
		if (AreaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AreaId);
		}
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DifficultyLevel);
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
		num += messageDatas_.CalculateSize(_repeated_messageDatas_codec);
		num += bLMPNONPLNI_.CalculateSize(_map_bLMPNONPLNI_codec);
		num += oMBLPOCHCHM_.CalculateSize(_repeated_oMBLPOCHCHM_codec);
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CAKGOGMEJOF other)
	{
		if (other != null)
		{
			messageDatas_.Add(other.messageDatas_);
			bLMPNONPLNI_.MergeFrom(other.bLMPNONPLNI_);
			oMBLPOCHCHM_.Add(other.oMBLPOCHCHM_);
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
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
			case 10u:
				messageDatas_.AddEntriesFrom(ref input, _repeated_messageDatas_codec);
				break;
			case 18u:
				bLMPNONPLNI_.AddEntriesFrom(ref input, _map_bLMPNONPLNI_codec);
				break;
			case 26u:
				oMBLPOCHCHM_.AddEntriesFrom(ref input, _repeated_oMBLPOCHCHM_codec);
				break;
			case 32u:
				AreaId = input.ReadUInt32();
				break;
			case 40u:
				DifficultyLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
