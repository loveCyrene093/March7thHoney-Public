using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMainMissionCustomValueCsReq : IMessage<UpdateMainMissionCustomValueCsReq>, IMessage, IEquatable<UpdateMainMissionCustomValueCsReq>, IDeepCloneable<UpdateMainMissionCustomValueCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateMainMissionCustomValueCsReq> _parser = new MessageParser<UpdateMainMissionCustomValueCsReq>(() => new UpdateMainMissionCustomValueCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DLCLDIAOIMKFieldNumber = 4;

	private string dLCLDIAOIMK_ = "";

	public const int ValueFieldNumber = 5;

	private uint value_;

	public const int MainMissionIdFieldNumber = 12;

	private uint mainMissionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMainMissionCustomValueCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMainMissionCustomValueCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DLCLDIAOIMK
	{
		get
		{
			return dLCLDIAOIMK_;
		}
		set
		{
			dLCLDIAOIMK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMainMissionCustomValueCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMainMissionCustomValueCsReq(UpdateMainMissionCustomValueCsReq other)
		: this()
	{
		dLCLDIAOIMK_ = other.dLCLDIAOIMK_;
		value_ = other.value_;
		mainMissionId_ = other.mainMissionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMainMissionCustomValueCsReq Clone()
	{
		return new UpdateMainMissionCustomValueCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMainMissionCustomValueCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMainMissionCustomValueCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DLCLDIAOIMK != other.DLCLDIAOIMK)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		if (MainMissionId != other.MainMissionId)
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
		if (DLCLDIAOIMK.Length != 0)
		{
			num ^= DLCLDIAOIMK.GetHashCode();
		}
		if (Value != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
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
		if (DLCLDIAOIMK.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DLCLDIAOIMK);
		}
		if (Value != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Value);
		}
		if (MainMissionId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MainMissionId);
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
		if (DLCLDIAOIMK.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DLCLDIAOIMK);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Value);
		}
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMainMissionCustomValueCsReq other)
	{
		if (other != null)
		{
			if (other.DLCLDIAOIMK.Length != 0)
			{
				DLCLDIAOIMK = other.DLCLDIAOIMK;
			}
			if (other.Value != 0)
			{
				Value = other.Value;
			}
			if (other.MainMissionId != 0)
			{
				MainMissionId = other.MainMissionId;
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
			case 34u:
				DLCLDIAOIMK = input.ReadString();
				break;
			case 40u:
				Value = input.ReadUInt32();
				break;
			case 96u:
				MainMissionId = input.ReadUInt32();
				break;
			}
		}
	}
}
