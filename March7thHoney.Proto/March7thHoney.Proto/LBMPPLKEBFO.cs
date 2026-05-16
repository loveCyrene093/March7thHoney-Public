using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBMPPLKEBFO : IMessage<LBMPPLKEBFO>, IMessage, IEquatable<LBMPPLKEBFO>, IDeepCloneable<LBMPPLKEBFO>, IBufferMessage
{
	private static readonly MessageParser<LBMPPLKEBFO> _parser = new MessageParser<LBMPPLKEBFO>(() => new LBMPPLKEBFO());

	private UnknownFieldSet _unknownFields;

	public const int EFJBFBENGKGFieldNumber = 6;

	private GNANMEADPBD eFJBFBENGKG_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBMPPLKEBFO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBMPPLKEBFOReflection.Descriptor.MessageTypes[0];

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
	public LBMPPLKEBFO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPPLKEBFO(LBMPPLKEBFO other)
		: this()
	{
		eFJBFBENGKG_ = ((other.eFJBFBENGKG_ != null) ? other.eFJBFBENGKG_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPPLKEBFO Clone()
	{
		return new LBMPPLKEBFO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBMPPLKEBFO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBMPPLKEBFO other)
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
		if (eFJBFBENGKG_ != null)
		{
			num ^= EFJBFBENGKG.GetHashCode();
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
		if (eFJBFBENGKG_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EFJBFBENGKG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (eFJBFBENGKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFJBFBENGKG);
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
	public void MergeFrom(LBMPPLKEBFO other)
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
			case 50u:
				if (eFJBFBENGKG_ == null)
				{
					EFJBFBENGKG = new GNANMEADPBD();
				}
				input.ReadMessage(EFJBFBENGKG);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
