using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyGamePlayStartScRsp : IMessage<TrainPartyGamePlayStartScRsp>, IMessage, IEquatable<TrainPartyGamePlayStartScRsp>, IDeepCloneable<TrainPartyGamePlayStartScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyGamePlayStartScRsp> _parser = new MessageParser<TrainPartyGamePlayStartScRsp>(() => new TrainPartyGamePlayStartScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MLBJFOPPBCMFieldNumber = 9;

	private FKPMOKOJNHP mLBJFOPPBCM_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyGamePlayStartScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyGamePlayStartScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKPMOKOJNHP MLBJFOPPBCM
	{
		get
		{
			return mLBJFOPPBCM_;
		}
		set
		{
			mLBJFOPPBCM_ = value;
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
	public TrainPartyGamePlayStartScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlayStartScRsp(TrainPartyGamePlayStartScRsp other)
		: this()
	{
		mLBJFOPPBCM_ = ((other.mLBJFOPPBCM_ != null) ? other.mLBJFOPPBCM_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlayStartScRsp Clone()
	{
		return new TrainPartyGamePlayStartScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyGamePlayStartScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyGamePlayStartScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MLBJFOPPBCM, other.MLBJFOPPBCM))
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
		if (mLBJFOPPBCM_ != null)
		{
			num ^= MLBJFOPPBCM.GetHashCode();
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
		if (mLBJFOPPBCM_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MLBJFOPPBCM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
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
		if (mLBJFOPPBCM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MLBJFOPPBCM);
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
	public void MergeFrom(TrainPartyGamePlayStartScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mLBJFOPPBCM_ != null)
		{
			if (mLBJFOPPBCM_ == null)
			{
				MLBJFOPPBCM = new FKPMOKOJNHP();
			}
			MLBJFOPPBCM.MergeFrom(other.MLBJFOPPBCM);
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
			case 74u:
				if (mLBJFOPPBCM_ == null)
				{
					MLBJFOPPBCM = new FKPMOKOJNHP();
				}
				input.ReadMessage(MLBJFOPPBCM);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
