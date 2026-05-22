using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyConditionUpdateScNotify : IMessage<MonopolyConditionUpdateScNotify>, IMessage, IEquatable<MonopolyConditionUpdateScNotify>, IDeepCloneable<MonopolyConditionUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyConditionUpdateScNotify> _parser = new MessageParser<MonopolyConditionUpdateScNotify>(() => new MonopolyConditionUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FFCDOBMOCDOFieldNumber = 14;

	private OHJFHJHFGBH fFCDOBMOCDO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyConditionUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyConditionUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHJFHJHFGBH FFCDOBMOCDO
	{
		get
		{
			return fFCDOBMOCDO_;
		}
		set
		{
			fFCDOBMOCDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConditionUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConditionUpdateScNotify(MonopolyConditionUpdateScNotify other)
		: this()
	{
		fFCDOBMOCDO_ = ((other.fFCDOBMOCDO_ != null) ? other.fFCDOBMOCDO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyConditionUpdateScNotify Clone()
	{
		return new MonopolyConditionUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyConditionUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyConditionUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FFCDOBMOCDO, other.FFCDOBMOCDO))
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
		if (fFCDOBMOCDO_ != null)
		{
			num ^= FFCDOBMOCDO.GetHashCode();
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
		if (fFCDOBMOCDO_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FFCDOBMOCDO);
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
		if (fFCDOBMOCDO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDOBMOCDO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyConditionUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fFCDOBMOCDO_ != null)
		{
			if (fFCDOBMOCDO_ == null)
			{
				FFCDOBMOCDO = new OHJFHJHFGBH();
			}
			FFCDOBMOCDO.MergeFrom(other.FFCDOBMOCDO);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fFCDOBMOCDO_ == null)
			{
				FFCDOBMOCDO = new OHJFHJHFGBH();
			}
			input.ReadMessage(FFCDOBMOCDO);
		}
	}
}
