using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildSelfDisplayAreaDiyCsReq : IMessage<TrainPartyBuildSelfDisplayAreaDiyCsReq>, IMessage, IEquatable<TrainPartyBuildSelfDisplayAreaDiyCsReq>, IDeepCloneable<TrainPartyBuildSelfDisplayAreaDiyCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildSelfDisplayAreaDiyCsReq> _parser = new MessageParser<TrainPartyBuildSelfDisplayAreaDiyCsReq>(() => new TrainPartyBuildSelfDisplayAreaDiyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ICJFLLDCFHMFieldNumber = 9;

	private KJGMAEGNBKL iCJFLLDCFHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildSelfDisplayAreaDiyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildSelfDisplayAreaDiyCsReqReflection.Descriptor.MessageTypes[0];

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
	public TrainPartyBuildSelfDisplayAreaDiyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyCsReq(TrainPartyBuildSelfDisplayAreaDiyCsReq other)
		: this()
	{
		iCJFLLDCFHM_ = ((other.iCJFLLDCFHM_ != null) ? other.iCJFLLDCFHM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyCsReq Clone()
	{
		return new TrainPartyBuildSelfDisplayAreaDiyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildSelfDisplayAreaDiyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildSelfDisplayAreaDiyCsReq other)
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
			output.WriteRawTag(74);
			output.WriteMessage(ICJFLLDCFHM);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildSelfDisplayAreaDiyCsReq other)
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iCJFLLDCFHM_ == null)
			{
				ICJFLLDCFHM = new KJGMAEGNBKL();
			}
			input.ReadMessage(ICJFLLDCFHM);
		}
	}
}
