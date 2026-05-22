using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NACCDDFCIKA : IMessage<NACCDDFCIKA>, IMessage, IEquatable<NACCDDFCIKA>, IDeepCloneable<NACCDDFCIKA>, IBufferMessage
{
	private static readonly MessageParser<NACCDDFCIKA> _parser = new MessageParser<NACCDDFCIKA>(() => new NACCDDFCIKA());

	private UnknownFieldSet _unknownFields;

	public const int AIJNGEFOADLFieldNumber = 10;

	private TrainPartyPassenger aIJNGEFOADL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NACCDDFCIKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NACCDDFCIKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassenger AIJNGEFOADL
	{
		get
		{
			return aIJNGEFOADL_;
		}
		set
		{
			aIJNGEFOADL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NACCDDFCIKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NACCDDFCIKA(NACCDDFCIKA other)
		: this()
	{
		aIJNGEFOADL_ = ((other.aIJNGEFOADL_ != null) ? other.aIJNGEFOADL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NACCDDFCIKA Clone()
	{
		return new NACCDDFCIKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NACCDDFCIKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NACCDDFCIKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AIJNGEFOADL, other.AIJNGEFOADL))
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
		if (aIJNGEFOADL_ != null)
		{
			num ^= AIJNGEFOADL.GetHashCode();
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
		if (aIJNGEFOADL_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(AIJNGEFOADL);
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
		if (aIJNGEFOADL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AIJNGEFOADL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NACCDDFCIKA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aIJNGEFOADL_ != null)
		{
			if (aIJNGEFOADL_ == null)
			{
				AIJNGEFOADL = new TrainPartyPassenger();
			}
			AIJNGEFOADL.MergeFrom(other.AIJNGEFOADL);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aIJNGEFOADL_ == null)
			{
				AIJNGEFOADL = new TrainPartyPassenger();
			}
			input.ReadMessage(AIJNGEFOADL);
		}
	}
}
