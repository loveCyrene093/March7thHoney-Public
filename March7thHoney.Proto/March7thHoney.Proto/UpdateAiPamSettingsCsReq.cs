using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateAiPamSettingsCsReq : IMessage<UpdateAiPamSettingsCsReq>, IMessage, IEquatable<UpdateAiPamSettingsCsReq>, IDeepCloneable<UpdateAiPamSettingsCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateAiPamSettingsCsReq> _parser = new MessageParser<UpdateAiPamSettingsCsReq>(() => new UpdateAiPamSettingsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EKBMIOCOLICFieldNumber = 10;

	private bool eKBMIOCOLIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateAiPamSettingsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateAiPamSettingsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EKBMIOCOLIC
	{
		get
		{
			return eKBMIOCOLIC_;
		}
		set
		{
			eKBMIOCOLIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateAiPamSettingsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateAiPamSettingsCsReq(UpdateAiPamSettingsCsReq other)
		: this()
	{
		eKBMIOCOLIC_ = other.eKBMIOCOLIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateAiPamSettingsCsReq Clone()
	{
		return new UpdateAiPamSettingsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateAiPamSettingsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateAiPamSettingsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EKBMIOCOLIC != other.EKBMIOCOLIC)
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
		if (EKBMIOCOLIC)
		{
			num ^= EKBMIOCOLIC.GetHashCode();
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
		if (EKBMIOCOLIC)
		{
			output.WriteRawTag(80);
			output.WriteBool(EKBMIOCOLIC);
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
		if (EKBMIOCOLIC)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateAiPamSettingsCsReq other)
	{
		if (other != null)
		{
			if (other.EKBMIOCOLIC)
			{
				EKBMIOCOLIC = other.EKBMIOCOLIC;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				EKBMIOCOLIC = input.ReadBool();
			}
		}
	}
}
