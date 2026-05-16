using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCMOACFMHCK : IMessage<FCMOACFMHCK>, IMessage, IEquatable<FCMOACFMHCK>, IDeepCloneable<FCMOACFMHCK>, IBufferMessage
{
	private static readonly MessageParser<FCMOACFMHCK> _parser = new MessageParser<FCMOACFMHCK>(() => new FCMOACFMHCK());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int JKCGCAMIFIAFieldNumber = 2;

	private uint jKCGCAMIFIA_;

	public const int TotalProgressFieldNumber = 3;

	private uint totalProgress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCMOACFMHCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCMOACFMHCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKCGCAMIFIA
	{
		get
		{
			return jKCGCAMIFIA_;
		}
		set
		{
			jKCGCAMIFIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalProgress
	{
		get
		{
			return totalProgress_;
		}
		set
		{
			totalProgress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMOACFMHCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMOACFMHCK(FCMOACFMHCK other)
		: this()
	{
		id_ = other.id_;
		jKCGCAMIFIA_ = other.jKCGCAMIFIA_;
		totalProgress_ = other.totalProgress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMOACFMHCK Clone()
	{
		return new FCMOACFMHCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCMOACFMHCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCMOACFMHCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (JKCGCAMIFIA != other.JKCGCAMIFIA)
		{
			return false;
		}
		if (TotalProgress != other.TotalProgress)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (JKCGCAMIFIA != 0)
		{
			num ^= JKCGCAMIFIA.GetHashCode();
		}
		if (TotalProgress != 0)
		{
			num ^= TotalProgress.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (JKCGCAMIFIA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JKCGCAMIFIA);
		}
		if (TotalProgress != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TotalProgress);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (JKCGCAMIFIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKCGCAMIFIA);
		}
		if (TotalProgress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalProgress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FCMOACFMHCK other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.JKCGCAMIFIA != 0)
			{
				JKCGCAMIFIA = other.JKCGCAMIFIA;
			}
			if (other.TotalProgress != 0)
			{
				TotalProgress = other.TotalProgress;
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
			case 8u:
				Id = input.ReadUInt32();
				break;
			case 16u:
				JKCGCAMIFIA = input.ReadUInt32();
				break;
			case 24u:
				TotalProgress = input.ReadUInt32();
				break;
			}
		}
	}
}
