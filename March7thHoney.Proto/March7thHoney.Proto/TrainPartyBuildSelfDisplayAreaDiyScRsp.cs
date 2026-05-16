using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildSelfDisplayAreaDiyScRsp : IMessage<TrainPartyBuildSelfDisplayAreaDiyScRsp>, IMessage, IEquatable<TrainPartyBuildSelfDisplayAreaDiyScRsp>, IDeepCloneable<TrainPartyBuildSelfDisplayAreaDiyScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildSelfDisplayAreaDiyScRsp> _parser = new MessageParser<TrainPartyBuildSelfDisplayAreaDiyScRsp>(() => new TrainPartyBuildSelfDisplayAreaDiyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ICJFLLDCFHMFieldNumber = 1;

	private KJGMAEGNBKL iCJFLLDCFHM_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildSelfDisplayAreaDiyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildSelfDisplayAreaDiyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL ICJFLLDCFHM
	{
		get
		{
			return iCJFLLDCFHM_;
		}
		set
		{
			iCJFLLDCFHM_ = value;
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
	public TrainPartyBuildSelfDisplayAreaDiyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyScRsp(TrainPartyBuildSelfDisplayAreaDiyScRsp other)
		: this()
	{
		iCJFLLDCFHM_ = ((other.iCJFLLDCFHM_ != null) ? other.iCJFLLDCFHM_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyScRsp Clone()
	{
		return new TrainPartyBuildSelfDisplayAreaDiyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildSelfDisplayAreaDiyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildSelfDisplayAreaDiyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ICJFLLDCFHM, other.ICJFLLDCFHM))
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
		if (iCJFLLDCFHM_ != null)
		{
			num ^= ICJFLLDCFHM.GetHashCode();
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
		if (iCJFLLDCFHM_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ICJFLLDCFHM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
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
		if (iCJFLLDCFHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ICJFLLDCFHM);
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
	public void MergeFrom(TrainPartyBuildSelfDisplayAreaDiyScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iCJFLLDCFHM_ != null)
		{
			if (iCJFLLDCFHM_ == null)
			{
				ICJFLLDCFHM = new KJGMAEGNBKL();
			}
			ICJFLLDCFHM.MergeFrom(other.ICJFLLDCFHM);
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
			case 10u:
				if (iCJFLLDCFHM_ == null)
				{
					ICJFLLDCFHM = new KJGMAEGNBKL();
				}
				input.ReadMessage(ICJFLLDCFHM);
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
