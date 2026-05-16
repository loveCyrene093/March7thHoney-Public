using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChessRogueStoryAeonTalkInfoScRsp : IMessage<GetChessRogueStoryAeonTalkInfoScRsp>, IMessage, IEquatable<GetChessRogueStoryAeonTalkInfoScRsp>, IDeepCloneable<GetChessRogueStoryAeonTalkInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> _parser = new MessageParser<GetChessRogueStoryAeonTalkInfoScRsp>(() => new GetChessRogueStoryAeonTalkInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int AHKFFCIEPDGFieldNumber = 9;

	private uint aHKFFCIEPDG_;

	public const int FOEJFEMLPPCFieldNumber = 11;

	private static readonly MapField<uint, uint>.Codec _map_fOEJFEMLPPC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 90u);

	private readonly MapField<uint, uint> fOEJFEMLPPC_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChessRogueStoryAeonTalkInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChessRogueStoryAeonTalkInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint AHKFFCIEPDG
	{
		get
		{
			return aHKFFCIEPDG_;
		}
		set
		{
			aHKFFCIEPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> FOEJFEMLPPC => fOEJFEMLPPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoScRsp(GetChessRogueStoryAeonTalkInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		aHKFFCIEPDG_ = other.aHKFFCIEPDG_;
		fOEJFEMLPPC_ = other.fOEJFEMLPPC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoScRsp Clone()
	{
		return new GetChessRogueStoryAeonTalkInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChessRogueStoryAeonTalkInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChessRogueStoryAeonTalkInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (AHKFFCIEPDG != other.AHKFFCIEPDG)
		{
			return false;
		}
		if (!FOEJFEMLPPC.Equals(other.FOEJFEMLPPC))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (AHKFFCIEPDG != 0)
		{
			num ^= AHKFFCIEPDG.GetHashCode();
		}
		num ^= FOEJFEMLPPC.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (AHKFFCIEPDG != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AHKFFCIEPDG);
		}
		fOEJFEMLPPC_.WriteTo(ref output, _map_fOEJFEMLPPC_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (AHKFFCIEPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHKFFCIEPDG);
		}
		num += fOEJFEMLPPC_.CalculateSize(_map_fOEJFEMLPPC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChessRogueStoryAeonTalkInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.AHKFFCIEPDG != 0)
			{
				AHKFFCIEPDG = other.AHKFFCIEPDG;
			}
			fOEJFEMLPPC_.MergeFrom(other.fOEJFEMLPPC_);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				AHKFFCIEPDG = input.ReadUInt32();
				break;
			case 90u:
				fOEJFEMLPPC_.AddEntriesFrom(ref input, _map_fOEJFEMLPPC_codec);
				break;
			}
		}
	}
}
