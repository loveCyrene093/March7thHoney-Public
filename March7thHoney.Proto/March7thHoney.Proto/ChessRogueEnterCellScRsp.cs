using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueEnterCellScRsp : IMessage<ChessRogueEnterCellScRsp>, IMessage, IEquatable<ChessRogueEnterCellScRsp>, IDeepCloneable<ChessRogueEnterCellScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueEnterCellScRsp> _parser = new MessageParser<ChessRogueEnterCellScRsp>(() => new ChessRogueEnterCellScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EIIAGABAFECFieldNumber = 4;

	private uint eIIAGABAFEC_;

	public const int LJMFGDFBLCKFieldNumber = 7;

	private ILEJGEDBEKF lJMFGDFBLCK_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int StageInfoFieldNumber = 13;

	private EJCCHHAAGNH stageInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueEnterCellScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueEnterCellScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

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
	public ChessRogueEnterCellScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterCellScRsp(ChessRogueEnterCellScRsp other)
		: this()
	{
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		lJMFGDFBLCK_ = ((other.lJMFGDFBLCK_ != null) ? other.lJMFGDFBLCK_.Clone() : null);
		retcode_ = other.retcode_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterCellScRsp Clone()
	{
		return new ChessRogueEnterCellScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueEnterCellScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueEnterCellScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (!object.Equals(LJMFGDFBLCK, other.LJMFGDFBLCK))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
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
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (lJMFGDFBLCK_ != null)
		{
			num ^= LJMFGDFBLCK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
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
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (lJMFGDFBLCK_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LJMFGDFBLCK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(StageInfo);
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
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (lJMFGDFBLCK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJMFGDFBLCK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueEnterCellScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		if (other.lJMFGDFBLCK_ != null)
		{
			if (lJMFGDFBLCK_ == null)
			{
				LJMFGDFBLCK = new ILEJGEDBEKF();
			}
			LJMFGDFBLCK.MergeFrom(other.LJMFGDFBLCK);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new EJCCHHAAGNH();
			}
			StageInfo.MergeFrom(other.StageInfo);
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
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 58u:
				if (lJMFGDFBLCK_ == null)
				{
					LJMFGDFBLCK = new ILEJGEDBEKF();
				}
				input.ReadMessage(LJMFGDFBLCK);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				if (stageInfo_ == null)
				{
					StageInfo = new EJCCHHAAGNH();
				}
				input.ReadMessage(StageInfo);
				break;
			}
		}
	}
}
