using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueStartScRsp : IMessage<ChessRogueStartScRsp>, IMessage, IEquatable<ChessRogueStartScRsp>, IDeepCloneable<ChessRogueStartScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueStartScRsp> _parser = new MessageParser<ChessRogueStartScRsp>(() => new ChessRogueStartScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LJMFGDFBLCKFieldNumber = 8;

	private ILEJGEDBEKF lJMFGDFBLCK_;

	public const int EOHOJECKODJFieldNumber = 11;

	private EBGJKPJNPBL eOHOJECKODJ_;

	public const int StageInfoFieldNumber = 12;

	private EJCCHHAAGNH stageInfo_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueStartScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueStartScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILEJGEDBEKF LJMFGDFBLCK
	{
		get
		{
			return lJMFGDFBLCK_;
		}
		set
		{
			lJMFGDFBLCK_ = value;
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
	public ChessRogueStartScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueStartScRsp(ChessRogueStartScRsp other)
		: this()
	{
		lJMFGDFBLCK_ = ((other.lJMFGDFBLCK_ != null) ? other.lJMFGDFBLCK_.Clone() : null);
		eOHOJECKODJ_ = ((other.eOHOJECKODJ_ != null) ? other.eOHOJECKODJ_.Clone() : null);
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueStartScRsp Clone()
	{
		return new ChessRogueStartScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueStartScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueStartScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LJMFGDFBLCK, other.LJMFGDFBLCK))
		{
			return false;
		}
		if (!object.Equals(EOHOJECKODJ, other.EOHOJECKODJ))
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (lJMFGDFBLCK_ != null)
		{
			num ^= LJMFGDFBLCK.GetHashCode();
		}
		if (eOHOJECKODJ_ != null)
		{
			num ^= EOHOJECKODJ.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (lJMFGDFBLCK_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(LJMFGDFBLCK);
		}
		if (eOHOJECKODJ_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EOHOJECKODJ);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(StageInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (lJMFGDFBLCK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJMFGDFBLCK);
		}
		if (eOHOJECKODJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOHOJECKODJ);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueStartScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lJMFGDFBLCK_ != null)
		{
			if (lJMFGDFBLCK_ == null)
			{
				LJMFGDFBLCK = new ILEJGEDBEKF();
			}
			LJMFGDFBLCK.MergeFrom(other.LJMFGDFBLCK);
		}
		if (other.eOHOJECKODJ_ != null)
		{
			if (eOHOJECKODJ_ == null)
			{
				EOHOJECKODJ = new EBGJKPJNPBL();
			}
			EOHOJECKODJ.MergeFrom(other.EOHOJECKODJ);
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new EJCCHHAAGNH();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 66u:
				if (lJMFGDFBLCK_ == null)
				{
					LJMFGDFBLCK = new ILEJGEDBEKF();
				}
				input.ReadMessage(LJMFGDFBLCK);
				break;
			case 90u:
				if (eOHOJECKODJ_ == null)
				{
					EOHOJECKODJ = new EBGJKPJNPBL();
				}
				input.ReadMessage(EOHOJECKODJ);
				break;
			case 98u:
				if (stageInfo_ == null)
				{
					StageInfo = new EJCCHHAAGNH();
				}
				input.ReadMessage(StageInfo);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
