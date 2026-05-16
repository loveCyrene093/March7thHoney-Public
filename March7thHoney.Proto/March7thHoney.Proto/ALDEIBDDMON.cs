using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ALDEIBDDMON : IMessage<ALDEIBDDMON>, IMessage, IEquatable<ALDEIBDDMON>, IDeepCloneable<ALDEIBDDMON>, IBufferMessage
{
	private static readonly MessageParser<ALDEIBDDMON> _parser = new MessageParser<ALDEIBDDMON>(() => new ALDEIBDDMON());

	private UnknownFieldSet _unknownFields;

	public const int EFJBFBENGKGFieldNumber = 14;

	private GNANMEADPBD eFJBFBENGKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ALDEIBDDMON> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ALDEIBDDMONReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNANMEADPBD EFJBFBENGKG
	{
		get
		{
			return eFJBFBENGKG_;
		}
		set
		{
			eFJBFBENGKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALDEIBDDMON()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALDEIBDDMON(ALDEIBDDMON other)
		: this()
	{
		eFJBFBENGKG_ = ((other.eFJBFBENGKG_ != null) ? other.eFJBFBENGKG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALDEIBDDMON Clone()
	{
		return new ALDEIBDDMON(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ALDEIBDDMON);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ALDEIBDDMON other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EFJBFBENGKG, other.EFJBFBENGKG))
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
		if (eFJBFBENGKG_ != null)
		{
			num ^= EFJBFBENGKG.GetHashCode();
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
		if (eFJBFBENGKG_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EFJBFBENGKG);
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
		if (eFJBFBENGKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFJBFBENGKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ALDEIBDDMON other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eFJBFBENGKG_ != null)
		{
			if (eFJBFBENGKG_ == null)
			{
				EFJBFBENGKG = new GNANMEADPBD();
			}
			EFJBFBENGKG.MergeFrom(other.EFJBFBENGKG);
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
			if (eFJBFBENGKG_ == null)
			{
				EFJBFBENGKG = new GNANMEADPBD();
			}
			input.ReadMessage(EFJBFBENGKG);
		}
	}
}
