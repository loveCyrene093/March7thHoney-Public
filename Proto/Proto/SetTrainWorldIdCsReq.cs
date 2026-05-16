using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetTrainWorldIdCsReq : IMessage<SetTrainWorldIdCsReq>, IMessage, IEquatable<SetTrainWorldIdCsReq>, IDeepCloneable<SetTrainWorldIdCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetTrainWorldIdCsReq> _parser = new MessageParser<SetTrainWorldIdCsReq>(() => new SetTrainWorldIdCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LLOLOEHPFHAFieldNumber = 13;

	private uint lLOLOEHPFHA_;

	public const int InteractIdFieldNumber = 15;

	private ulong interactId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetTrainWorldIdCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetTrainWorldIdCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLOLOEHPFHA
	{
		get
		{
			return lLOLOEHPFHA_;
		}
		set
		{
			lLOLOEHPFHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTrainWorldIdCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTrainWorldIdCsReq(SetTrainWorldIdCsReq other)
		: this()
	{
		lLOLOEHPFHA_ = other.lLOLOEHPFHA_;
		interactId_ = other.interactId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetTrainWorldIdCsReq Clone()
	{
		return new SetTrainWorldIdCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetTrainWorldIdCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetTrainWorldIdCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLOLOEHPFHA != other.LLOLOEHPFHA)
		{
			return false;
		}
		if (InteractId != other.InteractId)
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
		if (LLOLOEHPFHA != 0)
		{
			num ^= LLOLOEHPFHA.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
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
		if (LLOLOEHPFHA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LLOLOEHPFHA);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(InteractId);
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
		if (LLOLOEHPFHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLOLOEHPFHA);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetTrainWorldIdCsReq other)
	{
		if (other != null)
		{
			if (other.LLOLOEHPFHA != 0)
			{
				LLOLOEHPFHA = other.LLOLOEHPFHA;
			}
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
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
			case 104u:
				LLOLOEHPFHA = input.ReadUInt32();
				break;
			case 120u:
				InteractId = input.ReadUInt64();
				break;
			}
		}
	}
}
