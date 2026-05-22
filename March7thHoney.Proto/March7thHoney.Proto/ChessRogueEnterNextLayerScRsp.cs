using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueEnterNextLayerScRsp : IMessage<ChessRogueEnterNextLayerScRsp>, IMessage, IEquatable<ChessRogueEnterNextLayerScRsp>, IDeepCloneable<ChessRogueEnterNextLayerScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueEnterNextLayerScRsp> _parser = new MessageParser<ChessRogueEnterNextLayerScRsp>(() => new ChessRogueEnterNextLayerScRsp());

	private UnknownFieldSet _unknownFields;

	public const int StageInfoFieldNumber = 1;

	private EJCCHHAAGNH stageInfo_;

	public const int RogueGameInfoFieldNumber = 9;

	private ILEJGEDBEKF rogueGameInfo_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int EOHOJECKODJFieldNumber = 12;

	private EBGJKPJNPBL eOHOJECKODJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueEnterNextLayerScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueEnterNextLayerScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJCCHHAAGNH StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILEJGEDBEKF RogueGameInfo
	{
		get
		{
			return rogueGameInfo_;
		}
		set
		{
			rogueGameInfo_ = value;
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
	public EBGJKPJNPBL EOHOJECKODJ
	{
		get
		{
			return eOHOJECKODJ_;
		}
		set
		{
			eOHOJECKODJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterNextLayerScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterNextLayerScRsp(ChessRogueEnterNextLayerScRsp other)
		: this()
	{
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
		retcode_ = other.retcode_;
		eOHOJECKODJ_ = ((other.eOHOJECKODJ_ != null) ? other.eOHOJECKODJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterNextLayerScRsp Clone()
	{
		return new ChessRogueEnterNextLayerScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueEnterNextLayerScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueEnterNextLayerScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (!object.Equals(RogueGameInfo, other.RogueGameInfo))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EOHOJECKODJ, other.EOHOJECKODJ))
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
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (rogueGameInfo_ != null)
		{
			num ^= RogueGameInfo.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (eOHOJECKODJ_ != null)
		{
			num ^= EOHOJECKODJ.GetHashCode();
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
		if (stageInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StageInfo);
		}
		if (rogueGameInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RogueGameInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (eOHOJECKODJ_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EOHOJECKODJ);
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
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (rogueGameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGameInfo);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (eOHOJECKODJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOHOJECKODJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueEnterNextLayerScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new EJCCHHAAGNH();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.rogueGameInfo_ != null)
		{
			if (rogueGameInfo_ == null)
			{
				RogueGameInfo = new ILEJGEDBEKF();
			}
			RogueGameInfo.MergeFrom(other.RogueGameInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.eOHOJECKODJ_ != null)
		{
			if (eOHOJECKODJ_ == null)
			{
				EOHOJECKODJ = new EBGJKPJNPBL();
			}
			EOHOJECKODJ.MergeFrom(other.EOHOJECKODJ);
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
			case 10u:
				if (stageInfo_ == null)
				{
					StageInfo = new EJCCHHAAGNH();
				}
				input.ReadMessage(StageInfo);
				break;
			case 74u:
				if (rogueGameInfo_ == null)
				{
					RogueGameInfo = new ILEJGEDBEKF();
				}
				input.ReadMessage(RogueGameInfo);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (eOHOJECKODJ_ == null)
				{
					EOHOJECKODJ = new EBGJKPJNPBL();
				}
				input.ReadMessage(EOHOJECKODJ);
				break;
			}
		}
	}
}
