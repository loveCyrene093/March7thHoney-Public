using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CurAssistChangedNotify : IMessage<CurAssistChangedNotify>, IMessage, IEquatable<CurAssistChangedNotify>, IDeepCloneable<CurAssistChangedNotify>, IBufferMessage
{
	private static readonly MessageParser<CurAssistChangedNotify> _parser = new MessageParser<CurAssistChangedNotify>(() => new CurAssistChangedNotify());

	private UnknownFieldSet _unknownFields;

	public const int ILPKPBOKMENFieldNumber = 13;

	private PlayerAssistInfo iLPKPBOKMEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CurAssistChangedNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CurAssistChangedNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerAssistInfo ILPKPBOKMEN
	{
		get
		{
			return iLPKPBOKMEN_;
		}
		set
		{
			iLPKPBOKMEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurAssistChangedNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurAssistChangedNotify(CurAssistChangedNotify other)
		: this()
	{
		iLPKPBOKMEN_ = ((other.iLPKPBOKMEN_ != null) ? other.iLPKPBOKMEN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurAssistChangedNotify Clone()
	{
		return new CurAssistChangedNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CurAssistChangedNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CurAssistChangedNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ILPKPBOKMEN, other.ILPKPBOKMEN))
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
		if (iLPKPBOKMEN_ != null)
		{
			num ^= ILPKPBOKMEN.GetHashCode();
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
		if (iLPKPBOKMEN_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ILPKPBOKMEN);
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
		if (iLPKPBOKMEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ILPKPBOKMEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CurAssistChangedNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iLPKPBOKMEN_ != null)
		{
			if (iLPKPBOKMEN_ == null)
			{
				ILPKPBOKMEN = new PlayerAssistInfo();
			}
			ILPKPBOKMEN.MergeFrom(other.ILPKPBOKMEN);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iLPKPBOKMEN_ == null)
			{
				ILPKPBOKMEN = new PlayerAssistInfo();
			}
			input.ReadMessage(ILPKPBOKMEN);
		}
	}
}
